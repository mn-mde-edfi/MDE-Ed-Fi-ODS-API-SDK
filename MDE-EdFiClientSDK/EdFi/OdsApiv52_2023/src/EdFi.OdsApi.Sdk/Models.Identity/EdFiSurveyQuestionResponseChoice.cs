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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiSurveyQuestionResponseChoice
    /// </summary>
    [DataContract]
    public partial class EdFiSurveyQuestionResponseChoice :  IEquatable<EdFiSurveyQuestionResponseChoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyQuestionResponseChoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSurveyQuestionResponseChoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyQuestionResponseChoice" /> class.
        /// </summary>
        /// <param name="sortOrder">Sort order of this ResponseChoice within the complete list of choices attached to a SurveyQuestion. If sort order doesn&#39;t apply, the value of NumericValue or a unique, possibly sequential numeric value. (required).</param>
        /// <param name="numericValue">A valid numeric response. If paired with a TextValue, the numeric equivalent of the TextValue..</param>
        /// <param name="textValue">A valid text response. If paired with a NumericValue, the text equivalent of the NumericValue..</param>
        public EdFiSurveyQuestionResponseChoice(int? sortOrder = default(int?), int? numericValue = default(int?), string textValue = default(string))
        {
            // to ensure "sortOrder" is required (not null)
            if (sortOrder == null)
            {
                throw new InvalidDataException("sortOrder is a required property for EdFiSurveyQuestionResponseChoice and cannot be null");
            }
            else
            {
                this.SortOrder = sortOrder;
            }
            this.NumericValue = numericValue;
            this.TextValue = textValue;
        }
        
        /// <summary>
        /// Sort order of this ResponseChoice within the complete list of choices attached to a SurveyQuestion. If sort order doesn&#39;t apply, the value of NumericValue or a unique, possibly sequential numeric value.
        /// </summary>
        /// <value>Sort order of this ResponseChoice within the complete list of choices attached to a SurveyQuestion. If sort order doesn&#39;t apply, the value of NumericValue or a unique, possibly sequential numeric value.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// A valid numeric response. If paired with a TextValue, the numeric equivalent of the TextValue.
        /// </summary>
        /// <value>A valid numeric response. If paired with a TextValue, the numeric equivalent of the TextValue.</value>
        [DataMember(Name="numericValue", EmitDefaultValue=false)]
        public int? NumericValue { get; set; }

        /// <summary>
        /// A valid text response. If paired with a NumericValue, the text equivalent of the NumericValue.
        /// </summary>
        /// <value>A valid text response. If paired with a NumericValue, the text equivalent of the NumericValue.</value>
        [DataMember(Name="textValue", EmitDefaultValue=false)]
        public string TextValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSurveyQuestionResponseChoice {\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  NumericValue: ").Append(NumericValue).Append("\n");
            sb.Append("  TextValue: ").Append(TextValue).Append("\n");
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
            return this.Equals(input as EdFiSurveyQuestionResponseChoice);
        }

        /// <summary>
        /// Returns true if EdFiSurveyQuestionResponseChoice instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSurveyQuestionResponseChoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSurveyQuestionResponseChoice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.NumericValue == input.NumericValue ||
                    (this.NumericValue != null &&
                    this.NumericValue.Equals(input.NumericValue))
                ) && 
                (
                    this.TextValue == input.TextValue ||
                    (this.TextValue != null &&
                    this.TextValue.Equals(input.TextValue))
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
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.NumericValue != null)
                    hashCode = hashCode * 59 + this.NumericValue.GetHashCode();
                if (this.TextValue != null)
                    hashCode = hashCode * 59 + this.TextValue.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // TextValue (string) maxLength
            if(this.TextValue != null && this.TextValue.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TextValue, length must be less than 255.", new [] { "TextValue" });
            }

            yield break;
        }
    }

}
