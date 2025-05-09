######################################################################################################################
# TechDocs: https://edfi.atlassian.net/wiki/spaces/ODSAPIS3V62/pages/18219495/Using+Code+Generation+to+Create+an+SDK #
# URL Source: https://stage.api.education.mn.gov/edfiapi/metadata/2025                                               #
#                                                                                                                    #
# Input Parameters:                                                                                                  #
#    $uri - openApiMetadata URL from Staging due to timing of setting up the new school year                         #
#    $OdsVersion - Ods Version                                                                                       #
#                                                                                                                    #
# MNEdFiClientSDK
######################################################################################################################

# Static Variables
$headers = @{"Accept" = "application/json"}
$javaExecutable = "java.exe"
$openapiGeneratorJar = "openapi-generator-cli-6.0.1.jar"
$outputDir = "generated-sdk"

# Variables - update URI and Ods version if necessary
$uri = "https://stage.api.education.mn.gov/edfiapi/metadata/2026"

$OdsVersion = "v62"
$substrings = $uri -split "/"
$Year = $substrings[-1]   # Gets year of the URI
$finalDir = "OdsApi" + $OdsVersion + "_" + $year

# Get the OpenAPIGeneratorJar
if (-not (Test-Path $openapiGeneratorJar)) {
    Invoke-WebRequest -OutFile $openapiGeneratorJar "https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/6.0.1/$openapiGeneratorJar"
}

# Delete output folder when it exists
if (Test-Path $outputDir) { Remove-Item -Force -Recurse $outputDir }

# Delete final destination folder when it exists
if (Test-Path $finalDir) { Remove-Item -Force -Recurse $finalDir }

# Set parameters for Open API
$params = @(

    "-jar", $openapiGeneratorJar
    "generate",
    "-g", "csharp-netcore",
    "-o", $outputDir,
    "--additional-properties", "packageName=EdFi.OdsApi.Sdk,targetFramework=net6.0,netCoreProjectFile=true"
    "--global-property", "modelTests=false",
    "--global-property", "apiTests=false"
)

# Start processing...
try 
{
    # Get the metadata Json from the server
    $response = Invoke-RestMethod -Uri $uri -Method Get -Headers $headers

    # Process the Descriptors
    foreach( $entry in $response) 
    {
        if ( $entry.name -eq "Descriptors" )
        {
            # Create Descriptors 
            # (Client, Apis.Descriptors, Models.Descriptors)
            & $javaExecutable $params -i $entry.endpointUri --api-package Apis.Descriptors --model-package Models.Descriptors
        }
    }

    # Process the SIS Vendor Profile
    #foreach( $entry in $response) 
    #{
    #    if ( $entry.name -eq "Minnesota-Preview-SISVendor-Profile" )
    #    {
    #        # Create Minnesota SIS Vendor Profile 
    #        # (Client, Apis.Profiles.Minnesota_Preview_SISVendor_Profile and Models.Profiles.Minnesota_Preview_SISVendor_Profile)
    #        & $javaExecutable $params -i $entry.endpointUri --api-package Apis.Profiles.Minnesota_Preview_SISVendor_Profile  --model-package Models.Profiles.Minnesota_Preview_SISVendor_Profile
    #    }
    #}

    # Process the Minnesota Profile(s)
    foreach( $entry in $response) 
    {
        if ( $entry.name -like "Minnesota-*-SIS-Vendor-Profile" )
        {
            # Create the Profile
            # (Client, Apis.Profiles.Minnesota- ... -SISVendor-Profile, Models.Minnesota- ... -SISVendor-Profile)  
            $namespace = $entry.name.Replace("-", "_").Replace("SIS_Vendor", "SISVendor")
            & $javaExecutable $params -i $entry.endpointUri  --api-package Apis.Profiles.$namespace  --model-package Models.Profiles.$namespace
        }
    }

    # Move the Api and Model directories into the appropriate directory for the new year.
    # Format: OdsApiv<Ods-Version>_<schoolYear> see finalDir variable above
    # When satified, create PR to check-n the Directory
    Rename-Item -Path "generated-sdk" -NewName $finalDir

    Write-Host
    Write-Host   "##########################################################################################################################################"
    Write-Host   "#                                                                                                                                        #"
    Write-Host   "#  The final directory below - contains the SDK for the EdFi_Ods_$year database. Compile the SDK and run as described in the README.md.   #"
    Write-Host   "#  When satified, rerun this script to get rid of the VS bin directory the create a PR for the SDK.                                      #"  
    Write-Host   "#                                                                                                                                        #"
    Write-Host   "##########################################################################################################################################"
    Write-Host   "Final Director:  $finalDir "  
}
catch 
{
    Write-Error "Error occurred: $($_.Exception.Message)"
}
