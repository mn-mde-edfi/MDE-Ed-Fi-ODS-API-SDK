using System;
using System.Linq;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;

namespace EdFi.OdsApi.SdkClient
{
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
            System.Net.ServicePointManager.SecurityProtocol |=
                System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;

            // Oauth configuration
            var oauthUrl = "https://test.edfi5.education.mn.gov/sb24/api";
            var clientKey = "populated";
            var clientSecret = "populatedSecret";

            // TokenRetriever makes the oauth calls.  It has RestSharp dependency, install via NuGet
            var tokenRetriever = new TokenRetriever(oauthUrl, clientKey, clientSecret);

            // Plug Oauth access token. Tokens will need to be refreshed when they expire
            var configuration = new Configuration
            {
                AccessToken = tokenRetriever.ObtainNewBearerToken(),
                BasePath = "https://test.edfi5.education.mn.gov/sb24/api/data/v3"
            };

            Console.WriteLine("GET MN extension StudentSchoolAssociations");
            var mnssaApi = new StudentSchoolAssociationsApi(configuration);
            var mnssaResponse = mnssaApi.GetStudentSchoolAssociationsWithHttpInfo(null, null);
            var httpResponseCode = mnssaResponse.StatusCode;
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
            httpResponseCode = schoolsResponse.StatusCode;
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
            httpResponseCode = descriptorResponse.StatusCode;
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
            httpResponseCode = mnDescriptorResponse.StatusCode;
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
            Console.WriteLine("Hit ENTER key to continue...");
            Console.ReadLine();
        }
    }
}
