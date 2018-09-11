using System;
using System.Collections.Generic;
using System.Linq;
using EdFi.OdsApi.Sdk;
using EdFi.OdsApi.Models.MinnesotaSISVendorProfile;
using RestSharp;
  
namespace EdFi.OdsApi.Api.MinnesotaSISVendorProfile 
{
    public class StudentEducationOrganizationAssociationsApi 
    {
        private readonly IRestClient client;

        public StudentEducationOrganizationAssociationsApi(IRestClient client)
        {
            this.client = client;
        }
      
        /// <summary>
        /// Retrieves resources based with paging capabilities (using the &quot;Get All&quot; pattern). This GET operation provides access to resources using the &quot;Get All&quot; pattern. In this version of the API there is support for paging.
        /// </summary>
        /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
        /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<List<StudentEducationOrganizationAssociation_Readable>> GetStudentEducationOrganizationAssociationsAll(int? offset= null, int? limit= null) 
        {
            var request = new RestRequest("/studentEducationOrganizationAssociations", Method.GET);
            request.RequestFormat = DataFormat.Json;

            if (offset != null)
                request.AddParameter("offset", offset);
            if (limit != null)
                request.AddParameter("limit", limit);
            request.AddHeader("Accept", "application/vnd.ed-fi.studenteducationorganizationassociation.MinnesotaSISVendorProfile.readable+json");
            var response = client.Execute<List<StudentEducationOrganizationAssociation_Readable>>(request);

            return response;
        }
        /// <summary>
        /// Retrieves resources matching values of an example resource (using the &quot;Get By Example&quot; pattern). This GET operation provides access to resources using the &quot;Get by Example&quot; search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).
        /// </summary>
        /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
        /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
        /// <param name="responsibilityDescriptor">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</param>
        /// <param name="educationOrganizationId">EducationOrganization Identity Column</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student.</param>
        /// <param name="id"></param>
        /// <param name="birthCountryDescriptor">The country in which an individual is born.</param>
        /// <param name="limitedEnglishProficiencyDescriptor">An indication that the student has been identified as limited English proficient by the Language Proficiency Assessment Committee (LPAC), or English proficient.</param>
        /// <param name="sexType">A person's gender.</param>
        /// <param name="birthStateAbbreviationType">The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which an individual was born.</param>
        /// <param name="firstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.</param>
        /// <param name="middleName">A secondary name given to an individual at birth, baptism, or during another naming ceremony.</param>
        /// <param name="lastSurname">The name borne in common by members of a family.</param>
        /// <param name="generationCodeSuffix">An appendage, if any, used to denote an individual's generation in his family (e.g., Jr., Sr., III).</param>
        /// <param name="birthDate">The month, day, and year on which an individual was born.</param>
        /// <param name="birthCity">The city the student was born in.</param>
        /// <param name="birthInternationalProvince">For students born outside of the U.S., the Province or jurisdiction in which an individual is born.</param>
        /// <param name="dateEnteredUS">For students born outside of the U.S., the date the student entered the U.S.</param>
        /// <param name="multipleBirthStatus">Indicator of whether the student was born with other siblings (i.e., twins, triplets, etc.)</param>
        /// <param name="hispanicLatinoEthnicity">An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, &quot;Spanish origin,&quot; can be used in addition to &quot;Hispanic or Latino.&quot;</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<List<StudentEducationOrganizationAssociation_Readable>> GetStudentEducationOrganizationAssociationsByExample(int? offset= null, int? limit= null, string responsibilityDescriptor= null, int? educationOrganizationId= null, string studentUniqueId= null, string id= null, string birthCountryDescriptor= null, string limitedEnglishProficiencyDescriptor= null, string sexType= null, string birthStateAbbreviationType= null, string firstName= null, string middleName= null, string lastSurname= null, string generationCodeSuffix= null, DateTime? birthDate= null, string birthCity= null, string birthInternationalProvince= null, DateTime? dateEnteredUS= null, bool? multipleBirthStatus= null, bool? hispanicLatinoEthnicity= null) 
        {
            var request = new RestRequest("/studentEducationOrganizationAssociations", Method.GET);
            request.RequestFormat = DataFormat.Json;

            if (offset != null)
                request.AddParameter("offset", offset);
            if (limit != null)
                request.AddParameter("limit", limit);
            if (responsibilityDescriptor != null)
                request.AddParameter("responsibilityDescriptor", responsibilityDescriptor);
            if (educationOrganizationId != null)
                request.AddParameter("educationOrganizationId", educationOrganizationId);
            if (studentUniqueId != null)
                request.AddParameter("studentUniqueId", studentUniqueId);
            if (id != null)
                request.AddParameter("id", id);
            if (birthCountryDescriptor != null)
                request.AddParameter("birthCountryDescriptor", birthCountryDescriptor);
            if (limitedEnglishProficiencyDescriptor != null)
                request.AddParameter("limitedEnglishProficiencyDescriptor", limitedEnglishProficiencyDescriptor);
            if (sexType != null)
                request.AddParameter("sexType", sexType);
            if (birthStateAbbreviationType != null)
                request.AddParameter("birthStateAbbreviationType", birthStateAbbreviationType);
            if (firstName != null)
                request.AddParameter("firstName", firstName);
            if (middleName != null)
                request.AddParameter("middleName", middleName);
            if (lastSurname != null)
                request.AddParameter("lastSurname", lastSurname);
            if (generationCodeSuffix != null)
                request.AddParameter("generationCodeSuffix", generationCodeSuffix);
            if (birthDate != null)
                request.AddParameter("birthDate", birthDate);
            if (birthCity != null)
                request.AddParameter("birthCity", birthCity);
            if (birthInternationalProvince != null)
                request.AddParameter("birthInternationalProvince", birthInternationalProvince);
            if (dateEnteredUS != null)
                request.AddParameter("dateEnteredUS", dateEnteredUS);
            if (multipleBirthStatus != null)
                request.AddParameter("multipleBirthStatus", multipleBirthStatus);
            if (hispanicLatinoEthnicity != null)
                request.AddParameter("hispanicLatinoEthnicity", hispanicLatinoEthnicity);
            request.AddHeader("Accept", "application/vnd.ed-fi.studenteducationorganizationassociation.MinnesotaSISVendorProfile.readable+json");
            var response = client.Execute<List<StudentEducationOrganizationAssociation_Readable>>(request);

            return response;
        }
        /// <summary>
        /// Retrieves a specific resource using the values of the resource's natural key (using the &quot;Get By Key&quot; pattern). This GET operation provides access to resources using the &quot;Get by Key&quot; search pattern. The values of the natural key of the resource must be fully specified, and the service will return the matching result (if it exists).
        /// </summary>
        /// <param name="educationOrganizationId">EducationOrganization Identity Column</param>
        /// <param name="responsibilityDescriptor">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student.</param>
        /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<StudentEducationOrganizationAssociation_Readable> GetStudentEducationOrganizationAssociationByKey(int? educationOrganizationId, string responsibilityDescriptor, string studentUniqueId, string IfNoneMatch= null) 
        {
            var request = new RestRequest("/studentEducationOrganizationAssociations", Method.GET);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (educationOrganizationId == null || responsibilityDescriptor == null || studentUniqueId == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            if (educationOrganizationId != null)
                request.AddParameter("educationOrganizationId", educationOrganizationId);
            if (responsibilityDescriptor != null)
                request.AddParameter("responsibilityDescriptor", responsibilityDescriptor);
            if (studentUniqueId != null)
                request.AddParameter("studentUniqueId", studentUniqueId);
            request.AddHeader("If-None-Match", IfNoneMatch);
            request.AddHeader("Accept", "application/vnd.ed-fi.studenteducationorganizationassociation.MinnesotaSISVendorProfile.readable+json");
            var response = client.Execute<StudentEducationOrganizationAssociation_Readable>(request);

            return response;
        }
        /// <summary>
        /// Creates or updates resources based on the natural key values of the supplied resource. The POST operation can be used to create or update resources. In database terms, this is often referred to as an &quot;upsert&quot; operation (insert + update).  Clients should NOT include the resource &quot;id&quot; in the JSON body because it will result in an error (you must use a PUT operation to update a resource by &quot;id&quot;). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.
        /// </summary>
        /// <param name="body">The JSON representation of the &quot;studentEducationOrganizationAssociation&quot; resource to be created or updated.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse PostStudentEducationOrganizationAssociations(StudentEducationOrganizationAssociation_Writable body) 
        {
            var request = new RestRequest("/studentEducationOrganizationAssociations", Method.POST);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (body == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddBody(body);
            request.Parameters.First(param => param.Type == ParameterType.RequestBody).Name = "application/vnd.ed-fi.studenteducationorganizationassociation.MinnesotaSISVendorProfile.writable+json";
            var response = client.Execute(request);

            var location = response.Headers.FirstOrDefault(x => x.Name == "Location");

            if (location != null && !string.IsNullOrWhiteSpace(location.Value.ToString()))
                body.id = location.Value.ToString().Split('/').Last();
            return response;
        }
        /// <summary>
        /// Retrieves a specific resource using the resource's identifier (using the &quot;Get By Id&quot; pattern). This GET operation retrieves a resource by the specified resource identifier.
        /// </summary>
        /// <param name="id">A resource identifier specifying the resource to be retrieved.</param>
        /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<StudentEducationOrganizationAssociation_Readable> GetStudentEducationOrganizationAssociationsById(string id, string IfNoneMatch= null) 
        {
            var request = new RestRequest("/studentEducationOrganizationAssociations/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("If-None-Match", IfNoneMatch);
            request.AddHeader("Accept", "application/vnd.ed-fi.studenteducationorganizationassociation.MinnesotaSISVendorProfile.readable+json");
            var response = client.Execute<StudentEducationOrganizationAssociation_Readable>(request);

            return response;
        }
        /// <summary>
        /// Updates or creates a resource based on the resource identifier. The PUT operation is used to update or create a resource by identifier.  If the resource doesn't exist, the resource will be created using that identifier.  Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource &quot;id&quot; is provided in the JSON body, it will be ignored as well.
        /// </summary>
        /// <param name="id">A resource identifier specifying the resource to be updated.</param>
        /// <param name="IfMatch">The ETag header value used to prevent the PUT from updating a resource modified by another consumer.</param>
        /// <param name="body">The JSON representation of the &quot;studentEducationOrganizationAssociation&quot; resource to be updated.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse PutStudentEducationOrganizationAssociation(string id, string IfMatch, StudentEducationOrganizationAssociation_Writable body) 
        {
            var request = new RestRequest("/studentEducationOrganizationAssociations/{id}", Method.PUT);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null || body == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("If-Match", IfMatch);
            request.AddBody(body);
            request.Parameters.First(param => param.Type == ParameterType.RequestBody).Name = "application/vnd.ed-fi.studenteducationorganizationassociation.MinnesotaSISVendorProfile.writable+json";
            var response = client.Execute(request);

            var location = response.Headers.FirstOrDefault(x => x.Name == "Location");

            if (location != null && !string.IsNullOrWhiteSpace(location.Value.ToString()))
                body.id = location.Value.ToString().Split('/').Last();
            return response;
        }
        /// <summary>
        /// Deletes an existing resource using the resource identifier. The DELETE operation is used to delete an existing resource by identifier.  If the resource doesn't exist, an error will result (the resource will not be found).
        /// </summary>
        /// <param name="id">A resource identifier specifying the resource to be deleted.</param>
        /// <param name="IfMatch">The ETag header value used to prevent the DELETE from removing a resource modified by another consumer.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse DeleteStudentEducationOrganizationAssociationById(string id, string IfMatch= null) 
        {
            var request = new RestRequest("/studentEducationOrganizationAssociations/{id}", Method.DELETE);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("If-Match", IfMatch);
            var response = client.Execute(request);

            return response;
        }
        }
    }

