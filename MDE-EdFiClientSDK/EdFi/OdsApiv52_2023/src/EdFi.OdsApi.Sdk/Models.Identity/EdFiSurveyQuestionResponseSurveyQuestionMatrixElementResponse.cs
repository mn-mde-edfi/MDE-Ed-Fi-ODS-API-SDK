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
    /// EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse
    /// </summary>
    [DataContract]
    public partial class EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse :  IEquatable<EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse" /> class.
        /// </summary>
        /// <param name="matrixElement">For matrix questions, the text identifying each row of the matrix. (required).</param>
        /// <param name="maxNumericResponse">The maximum score response to the question..</param>
        /// <param name="minNumericResponse">The minimum score response to the question..</param>
        /// <param name="noResponse">Indicates there was no response to the question..</param>
        /// <param name="numericResponse">The numeric response to the question..</param>
        /// <param name="textResponse">The text response(s) for the question..</param>
        public EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse(string matrixElement = default(string), int? maxNumericResponse = default(int?), int? minNumericResponse = default(int?), bool? noResponse = default(bool?), int? numericResponse = default(int?), string textResponse = default(string))
        {
            // to ensure "matrixElement" is required (not null)
            if (matrixElement == null)
            {
                throw new InvalidDataException("matrixElement is a required property for EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse and cannot be null");
            }
            else
            {
                this.MatrixElement = matrixElement;
            }
            this.MaxNumericResponse = maxNumericResponse;
            this.MinNumericResponse = minNumericResponse;
            this.NoResponse = noResponse;
            this.NumericResponse = numericResponse;
            this.TextResponse = textResponse;
        }
        
        /// <summary>
        /// For matrix questions, the text identifying each row of the matrix.
        /// </summary>
        /// <value>For matrix questions, the text identifying each row of the matrix.</value>
        [DataMember(Name="matrixElement", EmitDefaultValue=false)]
        public string MatrixElement { get; set; }

        /// <summary>
        /// The maximum score response to the question.
        /// </summary>
        /// <value>The maximum score response to the question.</value>
        [DataMember(Name="maxNumericResponse", EmitDefaultValue=false)]
        public int? MaxNumericResponse { get; set; }

        /// <summary>
        /// The minimum score response to the question.
        /// </summary>
        /// <value>The minimum score response to the question.</value>
        [DataMember(Name="minNumericResponse", EmitDefaultValue=false)]
        public int? MinNumericResponse { get; set; }

        /// <summary>
        /// Indicates there was no response to the question.
        /// </summary>
        /// <value>Indicates there was no response to the question.</value>
        [DataMember(Name="noResponse", EmitDefaultValue=false)]
        public bool? NoResponse { get; set; }

        /// <summary>
        /// The numeric response to the question.
        /// </summary>
        /// <value>The numeric response to the question.</value>
        [DataMember(Name="numericResponse", EmitDefaultValue=false)]
        public int? NumericResponse { get; set; }

        /// <summary>
        /// The text response(s) for the question.
        /// </summary>
        /// <value>The text response(s) for the question.</value>
        [DataMember(Name="textResponse", EmitDefaultValue=false)]
        public string TextResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse {\n");
            sb.Append("  MatrixElement: ").Append(MatrixElement).Append("\n");
            sb.Append("  MaxNumericResponse: ").Append(MaxNumericResponse).Append("\n");
            sb.Append("  MinNumericResponse: ").Append(MinNumericResponse).Append("\n");
            sb.Append("  NoResponse: ").Append(NoResponse).Append("\n");
            sb.Append("  NumericResponse: ").Append(NumericResponse).Append("\n");
            sb.Append("  TextResponse: ").Append(TextResponse).Append("\n");
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
            return this.Equals(input as EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse);
        }

        /// <summary>
        /// Returns true if EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MatrixElement == input.MatrixElement ||
                    (this.MatrixElement != null &&
                    this.MatrixElement.Equals(input.MatrixElement))
                ) && 
                (
                    this.MaxNumericResponse == input.MaxNumericResponse ||
                    (this.MaxNumericResponse != null &&
                    this.MaxNumericResponse.Equals(input.MaxNumericResponse))
                ) && 
                (
                    this.MinNumericResponse == input.MinNumericResponse ||
                    (this.MinNumericResponse != null &&
                    this.MinNumericResponse.Equals(input.MinNumericResponse))
                ) && 
                (
                    this.NoResponse == input.NoResponse ||
                    (this.NoResponse != null &&
                    this.NoResponse.Equals(input.NoResponse))
                ) && 
                (
                    this.NumericResponse == input.NumericResponse ||
                    (this.NumericResponse != null &&
                    this.NumericResponse.Equals(input.NumericResponse))
                ) && 
                (
                    this.TextResponse == input.TextResponse ||
                    (this.TextResponse != null &&
                    this.TextResponse.Equals(input.TextResponse))
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
                if (this.MatrixElement != null)
                    hashCode = hashCode * 59 + this.MatrixElement.GetHashCode();
                if (this.MaxNumericResponse != null)
                    hashCode = hashCode * 59 + this.MaxNumericResponse.GetHashCode();
                if (this.MinNumericResponse != null)
                    hashCode = hashCode * 59 + this.MinNumericResponse.GetHashCode();
                if (this.NoResponse != null)
                    hashCode = hashCode * 59 + this.NoResponse.GetHashCode();
                if (this.NumericResponse != null)
                    hashCode = hashCode * 59 + this.NumericResponse.GetHashCode();
                if (this.TextResponse != null)
                    hashCode = hashCode * 59 + this.TextResponse.GetHashCode();
                return hashCode;
            }
        }
    }

}
