using System;
using System.Collections.Generic;
using System.Linq;
using EdFi.OdsApi.Sdk;
using EdFi.OdsApi.Models;
using RestSharp;
  
namespace EdFi.OdsApi.Api 
{
    public class V2Api 
    {
        private readonly IRestClient client;

        public V2Api(IRestClient client)
        {
            this.client = client;
        }
      
        /// <summary>
        /// Creates a new Unique Id for the given Identity information. Assumption here is that the user has verified that possible matches are not correct matches. Returns the created identity information along with the assigned Unique Id.
        /// </summary>
        /// <param name="body">Identity object to be created.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse IdentitiesV2_Create(IdentityCreateRequest body) 
        {
            var request = new RestRequest("/v2/identities", Method.POST);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (body == null ) 
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
        public IRestResponse<IdentityResponse> IdentitiesV2_GetById(string id) 
        {
            var request = new RestRequest("/v2/identities/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("Accept", "application/json, text/json");
            var response = client.Execute<IdentityResponse>(request);

            return response;
        }
        /// <summary>
        /// Retrieve a multiple person records from their Unique Ids. 
        /// </summary>
        /// <param name="body">Unique Ids of the persons to be retrieved.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<IdentitySearchResponse> IdentitiesV2_Find(List<string> body) 
        {
            var request = new RestRequest("/v2/identities/find", Method.POST);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (body == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddBody(body);
            request.AddHeader("Accept", "application/json, text/json");
            request.Parameters.First(param => param.Type == ParameterType.RequestBody).Name = "application/json, text/json";
            var response = client.Execute<IdentitySearchResponse>(request);

           
            return response;
        }
        /// <summary>
        /// Retrieve asynchronous search results from a previously created request. 
        /// </summary>
        /// <param name="id">The search token provided by a Find or Search request.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<IdentitySearchResponse> IdentitiesV2_Result(string id) 
        {
            var request = new RestRequest("/v2/identities/results/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("Accept", "application/json, text/json");
            var response = client.Execute<IdentitySearchResponse>(request);

            return response;
        }
        /// <summary>
        /// Lookup existing Unique Ids for a persons, or suggest possible matches. 
        /// </summary>
        /// <param name="body">One or more identity search request objects.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<IdentitySearchResponse> IdentitiesV2_Search(List<IdentitySearchRequest> body) 
        {
            var request = new RestRequest("/v2/identities/search", Method.POST);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (body == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddBody(body);
            request.AddHeader("Accept", "application/json, text/json");
            request.Parameters.First(param => param.Type == ParameterType.RequestBody).Name = "application/json, text/json";
            var response = client.Execute<IdentitySearchResponse>(request);

            return response;
        }
        }
    }

