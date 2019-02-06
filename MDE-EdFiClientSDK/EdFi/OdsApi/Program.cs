using System;
using System.Collections.Generic;
using System.Net;
using EdFi.OdsApi.Api;
using EdFi.OdsApi.Models;
using EdFi.OdsApi.Sdk;
using RestSharp;

using EdFi.OdsApi.Models.MinnesotaSISVendorProfile;
using EdFi.OdsApi.Models.Resources;
using EdFi.OdsApi.Api.Resources;

namespace EdFiClientSDK
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trust all SSL certs -- needed unless signed SSL certificates are configured.
            ServicePointManager.ServerCertificateValidationCallback =
                ((sender, certificate, chain, sslPolicyErrors) => true);

            // OAuth configuration
            var oauthUrl = "https://test.edfi.education.mn.gov/EdFi.Ods.WebApi/";
            var clientKey = "j57lM8oL5S7O";
            var clientSecret = "h9kgUASBEQhojU8HiSCsNPjz";

            // RestSharp dependency, install via NuGet
            var client = new RestClient("https://test.edfi.education.mn.gov/EdFi.Ods.WebApi/api/v2/2018/");

         
            // TokenRetriever makes the OAuth calls
            var tokenRetriever = new TokenRetriever(oauthUrl, clientKey, clientSecret);

            // Plug OAuth into RestSharp's authentication scheme
            client.Authenticator = new BearerTokenAuthenticator(tokenRetriever);

            // GET schools
            var api = new SchoolsApi(client);
            var response = api.GetSchoolsAll(null, null); // offset, limit

            var httpReponseCode = response.StatusCode; // returns System.Net.HttpStatusCode.OK
            Console.WriteLine("Response code is " + httpReponseCode);
            Console.WriteLine();
            
            // Create identity example setup
            //var IdentityApi = new identitiesApi(client, 2019);
            //var Identitiesresponse = IdentityApi.IdentitiesV2_Create(null);
            
            
            // Response data is serialized directly to typed model classes
            List<School> schools = response.Data;

            foreach (var school in schools)
                Console.WriteLine(school.schoolId + ": " + school.nameOfInstitution);

            Console.WriteLine();
            Console.WriteLine("Hit ENTER key to continue...");
            Console.ReadLine();
        }
    }
}

