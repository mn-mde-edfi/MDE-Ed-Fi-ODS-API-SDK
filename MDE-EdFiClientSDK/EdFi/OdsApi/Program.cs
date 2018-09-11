using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdFi.OdsApi.Sdk;
using EdFi.OdsApi.Models.Resources;
using EdFi.OdsApi.Api.Resources;
using RestSharp;

namespace MNEdFiClientSDK
{
    class Program
    {
        static void Main(string[] args)
        {// Trust all SSL certs -- needed unless signed SSL certificates are configured.
            System.Net.ServicePointManager.ServerCertificateValidationCallback =
                ((sender, certificate, chain, sslPolicyErrors) => true);

            //Explicitly configures outgoing network calls to use the latest version of TLS where possible.
            //Due to our reliance on some older libraries, the.NET framework won't necessarily default
            //to the latest unless we explicitly request it. Some hosting environments will not allow older versions
            //of TLS, and thus calls can fail without this extra configuration.
            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;

            // OAuth configuration
            var oauthUrl = "https://test.edfi.education.mn.gov/EdFi.Ods.WebApi/";
            var clientKey = "zAE28pM3Tzzz";
            var clientSecret = "eqqTCngL3s1FyJ7rq6m3czzz";

            // RestSharp dependency, install via NuGet
            var client = new RestClient("https://test.edfi.education.mn.gov/EdFi.Ods.WebApi/api/v2/2018/");

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
        }
    }
}
