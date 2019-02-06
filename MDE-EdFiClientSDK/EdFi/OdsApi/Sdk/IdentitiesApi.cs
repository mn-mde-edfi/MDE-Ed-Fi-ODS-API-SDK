using System;
using System.Collections.Generic;
using System.Linq;
using EdFi.OdsApi.Sdk;
using EdFi.OdsApi.Models;
using RestSharp;

namespace EdFi.OdsApi.Api
{
    public class identitiesApi
    {
        private readonly IRestClient client;

        public identitiesApi(IRestClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Validates info provided and Creates a new MARSS Student Id based off ID provided the given Identity information. Assumption here is that the user has verified that possible matches are not correct matches. Returns error code or the MARSSID/StudentUniqueID with leading zeros removed.
        /// </summary>
        /// <param name="body">Identity object to be created.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse IdentitiesV2_Create(IdentityCreateRequest body)
        {
            var request = new RestRequest("/v2/2019/identities", Method.POST);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (body == null)
                throw new ArgumentException("API method call is missing required parameters");
            request.AddBody(body);
            request.AddHeader("Accept", "application/json, text/json");
            request.Parameters.First(param => param.Type == ParameterType.RequestBody).Name = "application/json, text/json";
            var response = client.Execute(request);


            return response;
        }
        /// <summary>
        /// Retrieve a single person record from their Unique Id. Returns either a single identity or 404 and no data
        /// </summary>
        /// <param name="id">Unique Id of the identity to be retrieved</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>

    }
}


