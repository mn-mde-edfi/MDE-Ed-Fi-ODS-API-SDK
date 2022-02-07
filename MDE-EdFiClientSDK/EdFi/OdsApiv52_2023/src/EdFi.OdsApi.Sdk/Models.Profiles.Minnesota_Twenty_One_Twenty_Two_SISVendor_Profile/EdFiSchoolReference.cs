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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile
{
    /// <summary>
    /// EdFiSchoolReference
    /// </summary>
    [DataContract]
    public partial class EdFiSchoolReference :  IEquatable<EdFiSchoolReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSchoolReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolReference" /> class.
        /// </summary>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="link">link.</param>
        public EdFiSchoolReference(int? schoolId = default(int?), Link link = default(Link))
        {
            // to ensure "schoolId" is required (not null)
            if (schoolId == null)
            {
                throw new InvalidDataException("schoolId is a required property for EdFiSchoolReference and cannot be null");
            }
            else
            {
                this.SchoolId = schoolId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name="schoolId", EmitDefaultValue=false)]
        public int? SchoolId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSchoolReference {\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiSchoolReference);
        }

        /// <summary>
        /// Returns true if EdFiSchoolReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSchoolReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSchoolReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchoolId == input.SchoolId ||
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
            yield break;
        }
    }

}
