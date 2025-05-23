/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Three_Twenty_Four_SISVendor_Profile
{
    /// <summary>
    /// MnCourseReference
    /// </summary>
    [DataContract(Name = "mn_courseReference")]
    public partial class MnCourseReference : IEquatable<MnCourseReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnCourseReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseReference" /> class.
        /// </summary>
        /// <param name="courseCode">A unique alphanumeric code assigned to a course. (required).</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="link">link.</param>
        public MnCourseReference(string courseCode = default(string), int educationOrganizationId = default(int), Link link = default(Link))
        {
            // to ensure "courseCode" is required (not null)
            if (courseCode == null)
            {
                throw new ArgumentNullException("courseCode is a required property for MnCourseReference and cannot be null");
            }
            this.CourseCode = courseCode;
            this.EducationOrganizationId = educationOrganizationId;
            this.Link = link;
        }

        /// <summary>
        /// A unique alphanumeric code assigned to a course.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a course.</value>
        [DataMember(Name = "courseCode", IsRequired = true, EmitDefaultValue = false)]
        public string CourseCode { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", IsRequired = true, EmitDefaultValue = false)]
        public int EducationOrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnCourseReference {\n");
            sb.Append("  CourseCode: ").Append(CourseCode).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MnCourseReference);
        }

        /// <summary>
        /// Returns true if MnCourseReference instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCourseReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCourseReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CourseCode == input.CourseCode ||
                    (this.CourseCode != null &&
                    this.CourseCode.Equals(input.CourseCode))
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId)
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
                if (this.CourseCode != null)
                {
                    hashCode = (hashCode * 59) + this.CourseCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // CourseCode (string) maxLength
            if (this.CourseCode != null && this.CourseCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CourseCode, length must be less than 60.", new [] { "CourseCode" });
            }

            yield break;
        }
    }

}
