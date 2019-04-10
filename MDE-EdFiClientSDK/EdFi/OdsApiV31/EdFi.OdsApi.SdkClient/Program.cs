namespace EdFi.OdsApi.SdkClient
{
    using System;
    using System.Linq;

    using EdFi.OdsApi.Sdk.Apis.MN;
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
            var oauthUrl = "https://test.edfi.education.mn.gov/edfi.ods.webapi";
            var clientKey = "populatedSandbox";
            var clientSecret = "populatedSandboxSecret";

            // TokenRetriever makes the oauth calls.  It has RestSharp dependency, install via NuGet
            var tokenRetriever = new TokenRetriever(oauthUrl, clientKey, clientSecret);

            // Plug Oauth access token. Tokens will need to be refreshed when they expire
            var configuration = new Configuration()
                                {
                                    AccessToken = tokenRetriever.ObtainNewBearerToken(), 
                                    BasePath = "https://test.edfi.education.mn.gov/edfi.ods.webapi/data/v3"
            };
            
            Console.WriteLine("GET Schools via MN SISVendor profile");
            var schoolsApi = new SchoolsApi(configuration);
            var schoolsResponse = schoolsApi.GetSchoolsWithHttpInfo(null, null);
            var httpResponseCode = schoolsResponse.StatusCode; 
            var schools = schoolsResponse.Data;

            Console.WriteLine($"Response code is {httpResponseCode}");

            foreach (var school in schools.OrderBy(x => x.SchoolId))
            {
                Console.WriteLine($"{school.SchoolId}: {school.NameOfInstitution}");
            }

            Console.WriteLine();
            Console.WriteLine("GET Core Ed-Fi Descriptor: GiftedTalentedParticipation");
            var descriptorApi = new GiftedTalentedParticipationDescriptorsApi(configuration);
            var descriptorResponse = descriptorApi.GetGiftedTalentedParticipationDescriptorsWithHttpInfo(null, null);
            httpResponseCode = descriptorResponse.StatusCode;
            var descriptors = descriptorResponse.Data;
            Console.WriteLine($"Response code is {httpResponseCode}");

            foreach (var descriptor in descriptors.OrderBy(x => x.CodeValue))
            {
                Console.WriteLine($"{descriptor.CodeValue}: {descriptor.ShortDescription}");
            }

            Console.WriteLine();
            Console.WriteLine("GET MN Extension Descriptor: EarlyChildhoodScreeningExitStatus");
            var mnDescriptorApi = new EarlyChildhoodScreeningExitStatusDescriptorsApi(configuration);
            var mnDescriptorResponse = mnDescriptorApi.GetEarlyChildhoodScreeningExitStatusDescriptorsWithHttpInfo(null, null);
            httpResponseCode = mnDescriptorResponse.StatusCode;
            var mnDescriptors = mnDescriptorResponse.Data;
            Console.WriteLine($"Response code is {httpResponseCode}");

            foreach (var descriptor in mnDescriptors.OrderBy(x => x.CodeValue))
            {
                Console.WriteLine($"{descriptor.CodeValue}: {descriptor.ShortDescription}");
            }


            Console.WriteLine();
            Console.WriteLine("Hit ENTER key to continue...");
            Console.ReadLine();
        }
    }
}
