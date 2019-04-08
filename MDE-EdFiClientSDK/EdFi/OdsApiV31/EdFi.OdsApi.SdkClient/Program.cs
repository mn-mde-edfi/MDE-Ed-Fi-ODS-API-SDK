namespace EdFi.OdsApi.SdkClient
{
    using System;

    using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile;
    using EdFi.OdsApi.Sdk.Client;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Trust all SSL certs -- needed unless signed SSL certificates are configured.
            System.Net.ServicePointManager.ServerCertificateValidationCallback =
                ((sender, certificate, chain, sslPolicyErrors) => true);

            // Explicitly configures outgoing network calls to use the latest version of TLS where possible.
            // Due to our reliance on some older libraries, the.NET framework won't necessarily default
            // to the latest unless we explicitly request it. Some hosting environments will not allow older versions
            // of TLS, and thus calls can fail without this extra configuration.
            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;

            // Oauth configuration
            var oauthUrl = "https://test.edfi.education.mn.gov/edfi.ods.webapi/";
            var clientKey = "minimalSandbox";
            var clientSecret = "minimalSandboxSecret";

            // TokenRetriever makes the oauth calls.  It has RestSharp dependency, install via NuGet
            var tokenRetriever = new TokenRetriever(oauthUrl, clientKey, clientSecret);

            // Plug Oauth access token. Tokens will need to be refreshed when they expire
            var configuration = new Configuration()
                                {
                                    AccessToken = tokenRetriever.ObtainNewBearerToken(), 
                                    BasePath = "https://test.edfi.education.mn.gov/edfi.ods.webapi/data/v3"
            };

            // GET schools
            var api = new SchoolsApi(configuration);
            var response = api.GetSchoolsWithHttpInfo(null, null); // offset, limit
            var httpResponseCode = response.StatusCode; // returns System.Net.HttpStatusCode.OK
            var schools = response.Data;

            Console.WriteLine("Response code is " + httpResponseCode);

            foreach (var school in schools)
            {
                Console.WriteLine(school.NameOfInstitution);
            }
            Console.WriteLine();
            Console.WriteLine("Hit ENTER key to continue...");
            Console.ReadLine();
        }
    }
}
