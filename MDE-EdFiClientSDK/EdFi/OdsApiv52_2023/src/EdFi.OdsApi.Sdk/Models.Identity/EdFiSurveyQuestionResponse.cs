/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiSurveyQuestionResponse
    /// </summary>
    [DataContract]
    public partial class EdFiSurveyQuestionResponse :  IEquatable<EdFiSurveyQuestionResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyQuestionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSurveyQuestionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyQuestionResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="surveyQuestionReference">surveyQuestionReference (required).</param>
        /// <param name="surveyResponseReference">surveyResponseReference (required).</param>
        /// <param name="comment">Additional information provided by the responder about the question in the survey..</param>
        /// <param name="noResponse">Indicates there was no response to the question..</param>
        /// <param name="surveyQuestionMatrixElementResponses">An unordered collection of surveyQuestionResponseSurveyQuestionMatrixElementResponses. For matrix questions, the response for each row of the matrix..</param>
        /// <param name="values">An unordered collection of surveyQuestionResponseValues. For free-form, single- or multiple-selection questions, one or more responses..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiSurveyQuestionResponse(string id = default(string), EdFiSurveyQuestionReference surveyQuestionReference = default(EdFiSurveyQuestionReference), EdFiSurveyResponseReference surveyResponseReference = default(EdFiSurveyResponseReference), string comment = default(string), bool? noResponse = default(bool?), List<EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse> surveyQuestionMatrixElementResponses = default(List<EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse>), List<EdFiSurveyQuestionResponseValue> values = default(List<EdFiSurveyQuestionResponseValue>), string etag = default(string))
        {
            // to ensure "surveyQuestionReference" is required (not null)
            if (surveyQuestionReference == null)
            {
                throw new InvalidDataException("surveyQuestionReference is a required property for EdFiSurveyQuestionResponse and cannot be null");
            }
            else
            {
                this.SurveyQuestionReference = surveyQuestionReference;
            }
            // to ensure "surveyResponseReference" is required (not null)
            if (surveyResponseReference == null)
            {
                throw new InvalidDataException("surveyResponseReference is a required property for EdFiSurveyQuestionResponse and cannot be null");
            }
            else
            {
                this.SurveyResponseReference = surveyResponseReference;
            }
            this.Id = id;
            this.Comment = comment;
            this.NoResponse = noResponse;
            this.SurveyQuestionMatrixElementResponses = surveyQuestionMatrixElementResponses;
            this.Values = values;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SurveyQuestionReference
        /// </summary>
        [DataMember(Name="surveyQuestionReference", EmitDefaultValue=false)]
        public EdFiSurveyQuestionReference SurveyQuestionReference { get; set; }

        /// <summary>
        /// Gets or Sets SurveyResponseReference
        /// </summary>
        [DataMember(Name="surveyResponseReference", EmitDefaultValue=false)]
        public EdFiSurveyResponseReference SurveyResponseReference { get; set; }

        /// <summary>
        /// Additional information provided by the responder about the question in the survey.
        /// </summary>
        /// <value>Additional information provided by the responder about the question in the survey.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Indicates there was no response to the question.
        /// </summary>
        /// <value>Indicates there was no response to the question.</value>
        [DataMember(Name="noResponse", EmitDefaultValue=false)]
        public bool? NoResponse { get; set; }

        /// <summary>
        /// An unordered collection of surveyQuestionResponseSurveyQuestionMatrixElementResponses. For matrix questions, the response for each row of the matrix.
        /// </summary>
        /// <value>An unordered collection of surveyQuestionResponseSurveyQuestionMatrixElementResponses. For matrix questions, the response for each row of the matrix.</value>
        [DataMember(Name="surveyQuestionMatrixElementResponses", EmitDefaultValue=false)]
        public List<EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse> SurveyQuestionMatrixElementResponses { get; set; }

        /// <summary>
        /// An unordered collection of surveyQuestionResponseValues. For free-form, single- or multiple-selection questions, one or more responses.
        /// </summary>
        /// <value>An unordered collection of surveyQuestionResponseValues. For free-form, single- or multiple-selection questions, one or more responses.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<EdFiSurveyQuestionResponseValue> Values { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSurveyQuestionResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SurveyQuestionReference: ").Append(SurveyQuestionReference).Append("\n");
            sb.Append("  SurveyResponseReference: ").Append(SurveyResponseReference).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  NoResponse: ").Append(NoResponse).Append("\n");
            sb.Append("  SurveyQuestionMatrixElementResponses: ").Append(SurveyQuestionMatrixElementResponses).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiSurveyQuestionResponse);
        }

        /// <summary>
        /// Returns true if EdFiSurveyQuestionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSurveyQuestionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSurveyQuestionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SurveyQuestionReference == input.SurveyQuestionReference ||
                    (this.SurveyQuestionReference != null &&
                    this.SurveyQuestionReference.Equals(input.SurveyQuestionReference))
                ) && 
                (
                    this.SurveyResponseReference == input.SurveyResponseReference ||
                    (this.SurveyResponseReference != null &&
                    this.SurveyResponseReference.Equals(input.SurveyResponseReference))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.NoResponse == input.NoResponse ||
                    (this.NoResponse != null &&
                    this.NoResponse.Equals(input.NoResponse))
                ) && 
                (
                    this.SurveyQuestionMatrixElementResponses == input.SurveyQuestionMatrixElementResponses ||
                    this.SurveyQuestionMatrixElementResponses != null &&
                    this.SurveyQuestionMatrixElementResponses.SequenceEqual(input.SurveyQuestionMatrixElementResponses)
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SurveyQuestionReference != null)
                    hashCode = hashCode * 59 + this.SurveyQuestionReference.GetHashCode();
                if (this.SurveyResponseReference != null)
                    hashCode = hashCode * 59 + this.SurveyResponseReference.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.NoResponse != null)
                    hashCode = hashCode * 59 + this.NoResponse.GetHashCode();
                if (this.SurveyQuestionMatrixElementResponses != null)
                    hashCode = hashCode * 59 + this.SurveyQuestionMatrixElementResponses.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
