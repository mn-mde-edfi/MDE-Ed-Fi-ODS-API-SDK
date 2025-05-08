# MDE-Ed-Fi-ODS-API-SDK

<p>
C sharp client SDK to interact with the MN Ed-Fi ODS API.
<br>Note: LongPathsEnabled should be set to true in the registry. This is due to the filepath most likely exceeding 260 character.      
</p>

## Use the SDK Source files in a Sample C# Program
Open up Visual Studio and compile the SDK
1. Navigate to directory "..\MDE-Ed-Fi-ODS-API-SDK\MDE-EdFiClientSDK\EdFi\OdsApiv_2026"
2. Double-Click on the solution file ## "EdFi.OdsApi.Sdk.sln". This will open Visual Studio.
3. Right-click on the solution and click Restore NuGetPackages.
4. Build the solution. 

Create a new client project 
1. Right-click on the solution and add a new project. Choose the type Console App: C#, All Platforms.  
2. Name the project MNEdFiClientSDK.
3. Right-click on MNEdFiClientSDK > Set as Startup Project. 
4. Right-click MNEdFiClientSDK Dependencies node and click Add Project Reference > Check EdFi.OdsApi.Sdk.
5. In Solution Explorer, right-click EdFi.OdsApi.SdkClient Dependencies node and click Add Project Reference.

Edit the Program.cs and create TokenRetriever.cs  
(Note: EdFi.OdsApi.SdkClient also contains the file)
1. Open program.cs for editing.  
2. Replace exist code with the following:

Code Sniplet:
```
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;
using EdFi.OdsApi.SdkClient;

// Trust all SSL certs -- needed unless signed SSL certificates are configured.
System.Net.ServicePointManager.ServerCertificateValidationCallback =
    ((sender, certificate, chain, sslPolicyErrors) => true);

//Explicitly configures outgoing network calls to use the latest version of TLS where possible.
//Due to our reliance on some older libraries, the.NET framework won't necessarily default
//to the latest unless we explicitly request it. Some hosting environments will not allow older versions
//of TLS, and thus calls can fail without this extra configuration.
System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;

// Oauth configuration
var oauthUrl = "https://test.api.education.mn.gov/edfiapi/";
var clientKey = "populated";
var clientSecret = "populatedSecret";

// TokenRetriever makes the oauth calls.  It has RestSharp dependency, install via NuGet
var tokenRetriever = new TokenRetriever(oauthUrl, clientKey, clientSecret);

// Plug Oauth access token. Tokens will need to be refreshed when they expire
var configuration = new Configuration() { AccessToken = tokenRetriever.ObtainNewBearerToken(), BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3" };

Console.WriteLine("GET MN extension StudentSchoolAssociations");
var mnssaApi = new StudentSchoolAssociationsApi(configuration);
var mnssaResponse = mnssaApi.GetStudentSchoolAssociationsWithHttpInfo(null, null);
var httpResponseCode = (int)mnssaResponse.StatusCode;
var mnssas = mnssaResponse.Data;
Console.WriteLine($"Response code is {httpResponseCode}");

if (httpResponseCode == 200 && mnssas != null && mnssas.Count > 0)
{
    foreach (var mnssa in mnssas)
    {
        Console.WriteLine($"{mnssa.StudentReference.StudentUniqueId} / {mnssa.SchoolReference.SchoolId}");
    }
}
Console.WriteLine();


Console.WriteLine("GET Schools via MN SISVendor profile");
var schoolsApi = new SchoolsApi(configuration);
var schoolsResponse = schoolsApi.GetSchoolsWithHttpInfo(null, null);
httpResponseCode = (int)schoolsResponse.StatusCode;
var schools = schoolsResponse.Data;
Console.WriteLine($"Response code is {httpResponseCode}");

if (httpResponseCode == 200 && schools != null && schools.Count > 0)
{
    foreach (var school in schools.OrderBy(x => x.SchoolId))
    {
        Console.WriteLine($"{school.SchoolId}: {school.NameOfInstitution}");
    }
}


Console.WriteLine();
Console.WriteLine("GET Core Ed-Fi Descriptor: GiftedTalentedParticipation");
var descriptorApi = new GiftedTalentedParticipationDescriptorsApi(configuration);
var descriptorResponse = descriptorApi.GetGiftedTalentedParticipationDescriptorsWithHttpInfo(null, null);
httpResponseCode = (int)descriptorResponse.StatusCode;
var descriptors = descriptorResponse.Data;
Console.WriteLine($"Response code is {httpResponseCode}");

if (httpResponseCode == 200 && descriptors != null && descriptors.Count > 0)
{
    foreach (var descriptor in descriptors.OrderBy(x => x.CodeValue))
    {
        Console.WriteLine($"{descriptor.CodeValue}: {descriptor.ShortDescription}");
    }
}

Console.WriteLine();
Console.WriteLine("GET MN Extension Descriptor: EarlyChildhoodScreeningExitStatus");
var mnDescriptorApi = new EarlyChildhoodScreeningExitStatusDescriptorsApi(configuration);
var mnDescriptorResponse =
    mnDescriptorApi.GetEarlyChildhoodScreeningExitStatusDescriptorsWithHttpInfo(null, null);
httpResponseCode = (int)mnDescriptorResponse.StatusCode;
var mnDescriptors = mnDescriptorResponse.Data;
Console.WriteLine($"Response code is {httpResponseCode}");

if (httpResponseCode == 200 && mnDescriptors != null && mnDescriptors.Count > 0)
{
    foreach (var descriptor in mnDescriptors.OrderBy(x => x.CodeValue))
    {
        Console.WriteLine($"{descriptor.CodeValue}: {descriptor.ShortDescription}");
    }
}


Console.WriteLine();
Console.WriteLine("GET Students  via MN SISVendor profile");
int totalCount = 0;
var apiInstance = new StudentsApi(configuration);
apiInstance.Configuration.DefaultHeaders.Add("Content-Type", "application/json");

// Fetch a single record with the totalCount flag set to true to retrieve the total number of records available
var studentWithHttpInfo = apiInstance.GetStudentsWithHttpInfo(limit: 1, offset: 0, totalCount: true);

// Parse the total count value out of the "Total-Count" response header
var httpReponseCode = studentWithHttpInfo.StatusCode; // returns System.Net.HttpStatusCode.OK
int.TryParse(studentWithHttpInfo.Headers["Total-Count"].First(), out totalCount);

Console.WriteLine("Response code is " + httpReponseCode + ". TotalCount is " + totalCount);

int offset = 0;
int limit = 100;
var students = new List<EdFiStudentReadable>();

while (offset < totalCount)
{
    Console.WriteLine($"Fetching student records {offset} through {Math.Min(offset + limit, totalCount)} of {totalCount}");
    students.AddRange(apiInstance.GetStudents(limit: limit, offset: 0));
    offset += limit;
}

Console.WriteLine();
Console.WriteLine("Student Results");

foreach (var student in students)
{
    Console.WriteLine($"Student: {student.StudentUniqueId}, {student.FirstName}, {student.LastSurname}");
}

Console.WriteLine();
Console.WriteLine("Hit ENTER key to continue...");
Console.ReadLine();

```

3. The client key and secret are will need to be replaced to match a MN sandbox environment with sample data.

```
var clientKey = "your-key-from-sandbox-admin-site";
var clientSecret = "your-key-from-sandbox-admin-secret";
```

4. Add a .cs file named TokenRetriever.cs and copy the following code to help with OAuth integration.
(Note: EdFi.OdsApi.SdkClient also contains the file)

Code Sniplet:

```
using System.Net;
using System.Runtime.Serialization;
using System.Security.Authentication;
using EdFi.OdsApi.Sdk.Client;

namespace EdFi.OdsApi.SdkClient
{
    public class TokenRetriever
    {
        private string oauthUrl;
        private string clientKey;
        private string clientSecret;

        public TokenRetriever(string oauthUrl, string clientKey, string clientSecret)
        {
            this.oauthUrl = oauthUrl;
            this.clientKey = clientKey;
            this.clientSecret = clientSecret;
        }

        public string ObtainNewBearerToken()
        {
            var oauthClient = new ApiClient(oauthUrl);
            return GetBearerToken(oauthClient);
        }

        private string GetBearerToken(ApiClient oauthClient)
        {
            var configuration = new Configuration() { BasePath = oauthUrl };
            var bearerTokenRequestOptions = new RequestOptions() { Operation = String.Empty };
            bearerTokenRequestOptions.FormParameters.Add("Client_id", clientKey);
            bearerTokenRequestOptions.FormParameters.Add("Client_secret", clientSecret);
            bearerTokenRequestOptions.FormParameters.Add("Grant_type", "client_credentials");

            var bearerTokenResponse = oauthClient.Post<BearerTokenResponse>("oauth/token", bearerTokenRequestOptions, configuration);
            if (bearerTokenResponse.StatusCode != HttpStatusCode.OK)
            {
                throw new AuthenticationException("Unable to retrieve an access token. Error message: " +
                                                  bearerTokenResponse.Data.Error);
            }

            if (bearerTokenResponse.Data.Error != null || bearerTokenResponse.Data.TokenType != "bearer")
            {
                throw new AuthenticationException(
                    "Unable to retrieve an access token. Please verify that your application secret is correct.");
            }

            return bearerTokenResponse.Data.AccessToken;
        }
    }

    [DataContract]
    internal class BearerTokenResponse
    {
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public string ExpiresIn { get; set; }

        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; set; }

        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }
    }
}
```

5. Build the project and run it without debugging (Ctrl+F5) and you should see the results

