# MDE-Ed-Fi-ODS-API-SDK
A client SDK to interact with the MN Ed-Fi ODS API.
Step 5. Use the SDK in a Sample C# Program
Open up Visual Studio and create a new project. Choose the type Visual C# > Console Application. Name the project "EdFiClientSDK".


Add folders to the project, one for each of the folders generated from the previous step, i.e.,:
Api
\Resources
\Descriptors
\Types
\EnrollmentComposite
\School_and_Student
Models
\Resources
\Descriptors
\Types
\EnrollmentComposite
\School_and_Student
Sdk



Right-click on each of the folders and add the existing classes for each package. The files can be found at the following location: C:\Ed-Fi-ODS-API-SDK\CSharpSDK\EdFiClientSDK\EdFi\OdsApi. Be sure to select all of the generated SDK files for each package.

Use the Package Manager Console to install the RestSharp library. At the PM> prompt, enter "install-package restsharp -version 105.0.1".


Edit the Program.cs file and paste and add the following using statements at the top of the file: 

using EdFi.OdsApi.Sdk;
using EdFi.OdsApi.Models.Resources;
using EdFi.OdsApi.Api.Resources;
using RestSharp;
Edit the Program.cs file and paste the following into the Main method. The client and key are using a publicly available sandbox environment with sample data hosted by the Ed-Fi Alliance.

// Trust all SSL certs -- needed unless signed SSL certificates are configured.
System.Net.ServicePointManager.ServerCertificateValidationCallback =
    ((sender, certificate, chain, sslPolicyErrors) => true);
 
//Explicitly configures outgoing network calls to use the latest version of TLS where possible.
//Due to our reliance on some older libraries, the.NET framework won't necessarily default
//to the latest unless we explicitly request it. Some hosting environments will not allow older versions
//of TLS, and thus calls can fail without this extra configuration.
System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;
 
// OAuth configuration
var oauthUrl = "https://api.ed-fi.org/v2.5.0/api/";
var clientKey = "RvcohKz9zHI4";
var clientSecret = "E1iEFusaNf81xzCxwHfbolkC";
 
// RestSharp dependency, install via NuGet
var client = new RestClient("https://api.ed-fi.org/v2.5.0/api/api/v2.0/2018");
             
// TokenRetriever makes the OAuth calls
var tokenRetriever = new TokenRetriever(oauthUrl, clientKey, clientSecret);
 
// Plug Oauth into RestSharp's authentication scheme
client.Authenticator = new BearerTokenAuthenticator(tokenRetriever);
 
// GET schools
var api = new SchoolsApi(client);
 
var response = api.GetSchoolsAll(null, null); // offset, limit
 
var httpReponseCode = response.StatusCode; // returns System.Net.HttpStatusCode.OK
var schools = response.Data;
 
Console.WriteLine("Response code is " + httpReponseCode);
  
foreach (var school in schools)
{
    Console.WriteLine(school.nameOfInstitution);
}
Console.WriteLine();
Console.WriteLine("Hit ENTER key to continue...");
Console.ReadLine();
Build the project and run it without debugging (Ctrl+F5) and you should see the following results:

With that, you're done!

This exercise leveraged a publicly available instance of the API, which contains the surface for a core implementation. If you're working with a specific platform host and you already have a key/secret pair, a great next step is to use these same techniques to generate an SDK for that platform. If the platform host has extended the data model, your new code will automatically include those structures in the data access components in the generated code.
