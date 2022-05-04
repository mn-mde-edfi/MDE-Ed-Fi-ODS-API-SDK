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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_Baseline_SIS_Vendor_Profile
{
    /// <summary>
    /// EdFiCourseIdentificationCodeReadable
    /// </summary>
    [DataContract]
    public partial class EdFiCourseIdentificationCodeReadable :  IEquatable<EdFiCourseIdentificationCodeReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseIdentificationCodeReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseIdentificationCodeReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseIdentificationCodeReadable" /> class.
        /// </summary>
        /// <param name="courseIdentificationSystemDescriptor">A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students. (required).</param>
        /// <param name="assigningOrganizationIdentificationCode">The organization code or name assigning the Identification Code..</param>
        /// <param name="identificationCode">A unique number or alphanumeric code assigned to a course by a school, school system, state, or other agency or entity. For multi-part course codes, concatenate the parts separated by a \&quot;/\&quot;. For example, consider the following SCED code-    subject &#x3D; 20 Math    course &#x3D; 272 Geometry    level &#x3D; G General    credits &#x3D; 1.00   course sequence 1 of 1- would be entered as 20/272/G/1.00/1 of 1. (required).</param>
        public EdFiCourseIdentificationCodeReadable(string courseIdentificationSystemDescriptor = default(string), string assigningOrganizationIdentificationCode = default(string), string identificationCode = default(string))
        {
            // to ensure "courseIdentificationSystemDescriptor" is required (not null)
            if (courseIdentificationSystemDescriptor == null)
            {
                throw new InvalidDataException("courseIdentificationSystemDescriptor is a required property for EdFiCourseIdentificationCodeReadable and cannot be null");
            }
            else
            {
                this.CourseIdentificationSystemDescriptor = courseIdentificationSystemDescriptor;
            }
            // to ensure "identificationCode" is required (not null)
            if (identificationCode == null)
            {
                throw new InvalidDataException("identificationCode is a required property for EdFiCourseIdentificationCodeReadable and cannot be null");
            }
            else
            {
                this.IdentificationCode = identificationCode;
            }
            this.AssigningOrganizationIdentificationCode = assigningOrganizationIdentificationCode;
        }
        
        /// <summary>
        /// A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students.
        /// </summary>
        /// <value>A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students.</value>
        [DataMember(Name="courseIdentificationSystemDescriptor", EmitDefaultValue=false)]
        public string CourseIdentificationSystemDescriptor { get; set; }

        /// <summary>
        /// The organization code or name assigning the Identification Code.
        /// </summary>
        /// <value>The organization code or name assigning the Identification Code.</value>
        [DataMember(Name="assigningOrganizationIdentificationCode", EmitDefaultValue=false)]
        public string AssigningOrganizationIdentificationCode { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a course by a school, school system, state, or other agency or entity. For multi-part course codes, concatenate the parts separated by a \&quot;/\&quot;. For example, consider the following SCED code-    subject &#x3D; 20 Math    course &#x3D; 272 Geometry    level &#x3D; G General    credits &#x3D; 1.00   course sequence 1 of 1- would be entered as 20/272/G/1.00/1 of 1.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a course by a school, school system, state, or other agency or entity. For multi-part course codes, concatenate the parts separated by a \&quot;/\&quot;. For example, consider the following SCED code-    subject &#x3D; 20 Math    course &#x3D; 272 Geometry    level &#x3D; G General    credits &#x3D; 1.00   course sequence 1 of 1- would be entered as 20/272/G/1.00/1 of 1.</value>
        [DataMember(Name="identificationCode", EmitDefaultValue=false)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCourseIdentificationCodeReadable {\n");
            sb.Append("  CourseIdentificationSystemDescriptor: ").Append(CourseIdentificationSystemDescriptor).Append("\n");
            sb.Append("  AssigningOrganizationIdentificationCode: ").Append(AssigningOrganizationIdentificationCode).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
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
            return this.Equals(input as EdFiCourseIdentificationCodeReadable);
        }

        /// <summary>
        /// Returns true if EdFiCourseIdentificationCodeReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourseIdentificationCodeReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourseIdentificationCodeReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CourseIdentificationSystemDescriptor == input.CourseIdentificationSystemDescriptor ||
                    (this.CourseIdentificationSystemDescriptor != null &&
                    this.CourseIdentificationSystemDescriptor.Equals(input.CourseIdentificationSystemDescriptor))
                ) && 
                (
                    this.AssigningOrganizationIdentificationCode == input.AssigningOrganizationIdentificationCode ||
                    (this.AssigningOrganizationIdentificationCode != null &&
                    this.AssigningOrganizationIdentificationCode.Equals(input.AssigningOrganizationIdentificationCode))
                ) && 
                (
                    this.IdentificationCode == input.IdentificationCode ||
                    (this.IdentificationCode != null &&
                    this.IdentificationCode.Equals(input.IdentificationCode))
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
                if (this.CourseIdentificationSystemDescriptor != null)
                    hashCode = hashCode * 59 + this.CourseIdentificationSystemDescriptor.GetHashCode();
                if (this.AssigningOrganizationIdentificationCode != null)
                    hashCode = hashCode * 59 + this.AssigningOrganizationIdentificationCode.GetHashCode();
                if (this.IdentificationCode != null)
                    hashCode = hashCode * 59 + this.IdentificationCode.GetHashCode();
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
            // CourseIdentificationSystemDescriptor (string) maxLength
            if(this.CourseIdentificationSystemDescriptor != null && this.CourseIdentificationSystemDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CourseIdentificationSystemDescriptor, length must be less than 306.", new [] { "CourseIdentificationSystemDescriptor" });
            }

            // AssigningOrganizationIdentificationCode (string) maxLength
            if(this.AssigningOrganizationIdentificationCode != null && this.AssigningOrganizationIdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssigningOrganizationIdentificationCode, length must be less than 60.", new [] { "AssigningOrganizationIdentificationCode" });
            }

            // IdentificationCode (string) maxLength
            if(this.IdentificationCode != null && this.IdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationCode, length must be less than 60.", new [] { "IdentificationCode" });
            }

            yield break;
        }
    }

}
