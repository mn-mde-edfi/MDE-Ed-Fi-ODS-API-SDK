using System.Net;
using System.Runtime.Serialization;
using System.Security.Authentication;
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

// GET students
var apiInstance = new StudentsApi(configuration);
apiInstance.Configuration.DefaultHeaders.Add("Content-Type", "application/json");

// Fetch a single record with the totalCount flag set to true to retrieve the total number of records available
var studentWithHttpInfo = apiInstance.GetStudentsWithHttpInfo(limit: 1, offset: 0, totalCount: true);

var httpReponseCode = studentWithHttpInfo.StatusCode; // returns System.Net.HttpStatusCode.OK
Console.WriteLine("Response code is " + httpReponseCode);

// Parse the total count value out of the "Total-Count" response header
int.TryParse(studentWithHttpInfo.Headers["Total-Count"].First(), out var totalCount);

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


