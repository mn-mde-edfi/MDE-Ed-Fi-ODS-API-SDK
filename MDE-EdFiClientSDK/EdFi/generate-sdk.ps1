# TechDocs: https://techdocs.ed-fi.org/display/ODSAPI31/Using+Code+Generation+to+Create+an+SDK
# URL Source: https://test.edfi.education.mn.gov/sb21_/edfi.ods.webapi/metadata
$javaExecutable = "C:\Program Files (x86)\Java\jre1.8.0_241\bin\java.exe"
$metaDataUrl = "https://test.edfi.education.mn.gov/sb21_/edfi.ods.webapi/metadata"
$jarFile = "swagger-codegen-cli.jar"

if (!(Test-Path $jarFile)) {
    Invoke-WebRequest -OutFile $jarFile https://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/2.3.0/swagger-codegen-cli-2.3.0.jar
}

$outputDir = "GeneratedOdsApi"

if (Test-Path $outputDir) {
    Remove-Item -Force -Recurse $outputDir
}

# todo: put the parameters in a list of some kind and loop

cmd /c $javaExecutable -jar $jarFile generate -l csharp -o $outputDir -i "$metaDataUrl/data/v3/descriptors/swagger.json" --api-package Apis.Descriptors --model-package Models.Descriptors -DmodelTests=false -DapiTests=false -DpackageName='EdFi.OdsApi.Sdk'

cmd /c $javaExecutable -jar $jarFile generate -l csharp -o $outputDir -i "$metaDataUrl/identity/v2/swagger.json" --api-package Apis.Identity --model-package Models.Identity -DmodelTests=false -DapiTests=false -DpackageName='EdFi.OdsApi.Sdk'

cmd /c $javaExecutable -jar $jarFile generate -l csharp -o $outputDir -i "$metaDataUrl/data/v3/profiles/minnesota-preview-sisvendorprofile/swagger.json" --api-package Apis.Profiles.Minnesota_Preview_SISVendor_Profile --model-package Models.Profiles.Minnesota_Preview_SISVendor_Profile -DmodelTests=false -DapiTests=false -DpackageName='EdFi.OdsApi.Sdk'

cmd /c $javaExecutable -jar $jarFile generate -l csharp -o $outputDir -i "$metaDataUrl/data/v3/profiles/minnesota-twentytwentyone-sisvendorprofile/swagger.json" --api-package Apis.Profiles.Minnesota_Twenty_Twenty_One_SISVendor_Profile --model-package Models.Profiles.Minnesota_Twenty_Twenty_One_SISVendor_Profile -DmodelTests=false -DapiTests=false -DpackageName='EdFi.OdsApi.Sdk'

cmd /c $javaExecutable -jar $jarFile generate -l csharp -o $outputDir -i "$metaDataUrl/data/v3/profiles/minnesota-twentyone-twentytwo-sisvendorprofile/swagger.json" --api-package Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile --model-package Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile -DmodelTests=false -DapiTests=false -DpackageName='EdFi.OdsApi.Sdk'

#After generating files copy the Api and Model directories into the appropriate directory
