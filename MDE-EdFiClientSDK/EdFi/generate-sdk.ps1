# TechDocs: https://techdocs.ed-fi.org/display/ODSAPI31/Using+Code+Generation+to+Create+an+SDK
# URL Source: https://test.edfi.education.mn.gov/sb21_/edfi.ods.webapi/metadata
$javaExecutable = "java.exe"
$swaggerCodeGenJar = "swagger-codegen-cli.jar"
$metaDataUrl = "https://test.edfi5.education.mn.gov/api/metadata/"
$outputDir = "generated-sdk"

if (-not (Test-Path $swaggerCodeGenJar)) {
    Invoke-WebRequest -OutFile $swaggerCodeGenJar https://oss.sonatype.org/content/repositories/releases/io/swagger/swagger-codegen-cli/2.4.15/swagger-codegen-cli-2.4.15.jar
}

if (Test-Path $outputDir) { Remove-Item -Force -Recurse $outputDir }

$params = @(
    "-jar", $swaggerCodeGenJar
    "generate",
    "-l", "csharp",
    "-o", $outputDir,
    "-DmodelTests=false",
    "-DapiTests=false",
    "-DpackageName=EdFi.OdsApi.Sdk"
)

& $javaExecutable $params -i "$metaDataUrl/data/v3/descriptors/swagger.json"                                               --api-package Apis.Descriptors                                                  --model-package Models.Descriptors
& $javaExecutable $params -i "$metaDataUrl/identity/v2/swagger.json"                                                       --api-package Apis.Identity                                                     --model-package Models.Identity
& $javaExecutable $params -i "$metaDataUrl/data/v3/profiles/minnesota-preview-sisvendorprofile/swagger.json"               --api-package Apis.Profiles.Minnesota_Preview_SISVendor_Profile                 --model-package Models.Profiles.Minnesota_Preview_SISVendor_Profile
& $javaExecutable $params -i "$metaDataUrl/data/v3/profiles/minnesota-twentyone-twentytwo-sisvendorprofile/swagger.json"   --api-package Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile   --model-package Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile
& $javaExecutable $params -i "$metaDataUrl/data/v3/profiles/minnesota-twentytwo-twentythree-sisvendorprofile/swagger.json" --api-package Apis.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile --model-package Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile

# After generating files copy the Api and Model directories into the appropriate directory
