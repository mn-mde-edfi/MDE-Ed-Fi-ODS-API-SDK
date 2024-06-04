# TechDocs: https://techdocs.ed-fi.org/display/ODSAPI31/Using+Code+Generation+to+Create+an+SDK
# URL Source: https://test.edfi.education.mn.gov/sb21_/edfi.ods.webapi/metadata
$javaExecutable = "java.exe"
$openapiGeneratorJar = "openapi-generator-cli-6.0.1.jar"
$metaDataUrl = "https://test.edfi5.education.mn.gov/sb24/api/metadata"
$outputDir = "generated-sdk"

if (-not (Test-Path $openapiGeneratorJar)) {
    Invoke-WebRequest -OutFile $openapiGeneratorJar "https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/6.0.1/$openapiGeneratorJar"
}

if (Test-Path $outputDir) { Remove-Item -Force -Recurse $outputDir }

$params = @(
    "-jar", $openapiGeneratorJar
    "generate",
    "-g", "csharp-netcore",
    "-o", $outputDir,
    "--additional-properties", "packageName=EdFi.OdsApi.Sdk,targetFramework=net6.0,netCoreProjectFile=true"
    "--global-property", "modelTests=false",
    "--global-property", "apiTests=false"
)

& $javaExecutable $params -i "$metaDataUrl/data/v3/descriptors/swagger.json"                                                                --api-package Apis.Descriptors                                                              --model-package Models.Descriptors
# Removed according to MOAI-800
# & $javaExecutable $params -i "$metaDataUrl/identity/v2/swagger.json"                                                                      --api-package Apis.Identity                                                                 --model-package Models.Identity
& $javaExecutable $params -i "$metaDataUrl/data/v3/profiles/minnesota-preview-sisvendorprofile/swagger.json"                                --api-package Apis.Profiles.Minnesota_Preview_SISVendor_Profile                             --model-package Models.Profiles.Minnesota_Preview_SISVendor_Profile

& $javaExecutable $params -i "$metaDataUrl/data/v3/profiles/minnesota-twenty-two-twenty-three-sis-vendor-profile/swagger.json"              --api-package Apis.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile             --model-package Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile
& $javaExecutable $params -i "$metaDataUrl/data/v3/profiles/minnesota-twenty-three-twenty-four-sis-vendor-profile/swagger.json"             --api-package Apis.Profiles.Minnesota_Twenty_Three_Twenty_Four_SISVendor_Profile            --model-package Models.Profiles.Minnesota_Twenty_Three_Twenty_Four_SISVendor_Profile
& $javaExecutable $params -i "$metaDataUrl/data/v3/profiles/minnesota-twenty-four-twenty-five-sis-vendor-profile/swagger.json"              --api-package Apis.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile             --model-package Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile
# After generating files copy the Api and Model directories into the appropriate directory
