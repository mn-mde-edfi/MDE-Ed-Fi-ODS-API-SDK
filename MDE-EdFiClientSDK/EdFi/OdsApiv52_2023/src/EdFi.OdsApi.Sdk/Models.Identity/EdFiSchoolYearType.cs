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
    /// EdFiSchoolYearType
    /// </summary>
    [DataContract]
    public partial class EdFiSchoolYearType :  IEquatable<EdFiSchoolYearType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolYearType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSchoolYearType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolYearType" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="schoolYear">Key for School Year (required).</param>
        /// <param name="currentSchoolYear">The code for the current school year. (required).</param>
        /// <param name="schoolYearDescription">The description for the SchoolYear type. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiSchoolYearType(string id = default(string), int? schoolYear = default(int?), bool? currentSchoolYear = default(bool?), string schoolYearDescription = default(string), string etag = default(string))
        {
            // to ensure "schoolYear" is required (not null)
            if (schoolYear == null)
            {
                throw new InvalidDataException("schoolYear is a required property for EdFiSchoolYearType and cannot be null");
            }
            else
            {
                this.SchoolYear = schoolYear;
            }
            // to ensure "currentSchoolYear" is required (not null)
            if (currentSchoolYear == null)
            {
                throw new InvalidDataException("currentSchoolYear is a required property for EdFiSchoolYearType and cannot be null");
            }
            else
            {
                this.CurrentSchoolYear = currentSchoolYear;
            }
            // to ensure "schoolYearDescription" is required (not null)
            if (schoolYearDescription == null)
            {
                throw new InvalidDataException("schoolYearDescription is a required property for EdFiSchoolYearType and cannot be null");
            }
            else
            {
                this.SchoolYearDescription = schoolYearDescription;
            }
            this.Id = id;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Key for School Year
        /// </summary>
        /// <value>Key for School Year</value>
        [DataMember(Name="schoolYear", EmitDefaultValue=false)]
        public int? SchoolYear { get; set; }

        /// <summary>
        /// The code for the current school year.
        /// </summary>
        /// <value>The code for the current school year.</value>
        [DataMember(Name="currentSchoolYear", EmitDefaultValue=false)]
        public bool? CurrentSchoolYear { get; set; }

        /// <summary>
        /// The description for the SchoolYear type.
        /// </summary>
        /// <value>The description for the SchoolYear type.</value>
        [DataMember(Name="schoolYearDescription", EmitDefaultValue=false)]
        public string SchoolYearDescription { get; set; }

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
            sb.Append("class EdFiSchoolYearType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  CurrentSchoolYear: ").Append(CurrentSchoolYear).Append("\n");
            sb.Append("  SchoolYearDescription: ").Append(SchoolYearDescription).Append("\n");
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
            return this.Equals(input as EdFiSchoolYearType);
        }

        /// <summary>
        /// Returns true if EdFiSchoolYearType instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSchoolYearType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSchoolYearType input)
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
                    this.SchoolYear == input.SchoolYear ||
                    (this.SchoolYear != null &&
                    this.SchoolYear.Equals(input.SchoolYear))
                ) && 
                (
                    this.CurrentSchoolYear == input.CurrentSchoolYear ||
                    (this.CurrentSchoolYear != null &&
                    this.CurrentSchoolYear.Equals(input.CurrentSchoolYear))
                ) && 
                (
                    this.SchoolYearDescription == input.SchoolYearDescription ||
                    (this.SchoolYearDescription != null &&
                    this.SchoolYearDescription.Equals(input.SchoolYearDescription))
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
                if (this.SchoolYear != null)
                    hashCode = hashCode * 59 + this.SchoolYear.GetHashCode();
                if (this.CurrentSchoolYear != null)
                    hashCode = hashCode * 59 + this.CurrentSchoolYear.GetHashCode();
                if (this.SchoolYearDescription != null)
                    hashCode = hashCode * 59 + this.SchoolYearDescription.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
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
            // SchoolYearDescription (string) maxLength
            if(this.SchoolYearDescription != null && this.SchoolYearDescription.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SchoolYearDescription, length must be less than 50.", new [] { "SchoolYearDescription" });
            }

            yield break;
        }
    }

}
