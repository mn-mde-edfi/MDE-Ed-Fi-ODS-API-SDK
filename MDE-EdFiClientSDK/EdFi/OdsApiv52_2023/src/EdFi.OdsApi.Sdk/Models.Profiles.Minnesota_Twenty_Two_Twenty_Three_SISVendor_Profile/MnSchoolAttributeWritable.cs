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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile
{
    /// <summary>
    /// MnSchoolAttributeWritable
    /// </summary>
    [DataContract]
    public partial class MnSchoolAttributeWritable :  IEquatable<MnSchoolAttributeWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnSchoolAttributeWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnSchoolAttributeWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnSchoolAttributeWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="educationOrganizationIndicators">An unordered collection of schoolAttributeEducationOrganizationIndicators. An indicator or metric of an Education Organization..</param>
        /// <param name="titleIPartASchoolDesignationDescriptor">Denotes the Title I Part A designation for the school..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public MnSchoolAttributeWritable(string id = default(string), MnSchoolReference schoolReference = default(MnSchoolReference), List<MnSchoolAttributeEducationOrganizationIndicatorWritable> educationOrganizationIndicators = default(List<MnSchoolAttributeEducationOrganizationIndicatorWritable>), string titleIPartASchoolDesignationDescriptor = default(string), string etag = default(string))
        {
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new InvalidDataException("schoolReference is a required property for MnSchoolAttributeWritable and cannot be null");
            }
            else
            {
                this.SchoolReference = schoolReference;
            }
            this.Id = id;
            this.EducationOrganizationIndicators = educationOrganizationIndicators;
            this.TitleIPartASchoolDesignationDescriptor = titleIPartASchoolDesignationDescriptor;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name="schoolReference", EmitDefaultValue=false)]
        public MnSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// An unordered collection of schoolAttributeEducationOrganizationIndicators. An indicator or metric of an Education Organization.
        /// </summary>
        /// <value>An unordered collection of schoolAttributeEducationOrganizationIndicators. An indicator or metric of an Education Organization.</value>
        [DataMember(Name="educationOrganizationIndicators", EmitDefaultValue=false)]
        public List<MnSchoolAttributeEducationOrganizationIndicatorWritable> EducationOrganizationIndicators { get; set; }

        /// <summary>
        /// Denotes the Title I Part A designation for the school.
        /// </summary>
        /// <value>Denotes the Title I Part A designation for the school.</value>
        [DataMember(Name="titleIPartASchoolDesignationDescriptor", EmitDefaultValue=false)]
        public string TitleIPartASchoolDesignationDescriptor { get; set; }

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
            sb.Append("class MnSchoolAttributeWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  EducationOrganizationIndicators: ").Append(EducationOrganizationIndicators).Append("\n");
            sb.Append("  TitleIPartASchoolDesignationDescriptor: ").Append(TitleIPartASchoolDesignationDescriptor).Append("\n");
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
            return this.Equals(input as MnSchoolAttributeWritable);
        }

        /// <summary>
        /// Returns true if MnSchoolAttributeWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnSchoolAttributeWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnSchoolAttributeWritable input)
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
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.EducationOrganizationIndicators == input.EducationOrganizationIndicators ||
                    this.EducationOrganizationIndicators != null &&
                    this.EducationOrganizationIndicators.SequenceEqual(input.EducationOrganizationIndicators)
                ) && 
                (
                    this.TitleIPartASchoolDesignationDescriptor == input.TitleIPartASchoolDesignationDescriptor ||
                    (this.TitleIPartASchoolDesignationDescriptor != null &&
                    this.TitleIPartASchoolDesignationDescriptor.Equals(input.TitleIPartASchoolDesignationDescriptor))
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
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.EducationOrganizationIndicators != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationIndicators.GetHashCode();
                if (this.TitleIPartASchoolDesignationDescriptor != null)
                    hashCode = hashCode * 59 + this.TitleIPartASchoolDesignationDescriptor.GetHashCode();
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
            // TitleIPartASchoolDesignationDescriptor (string) maxLength
            if(this.TitleIPartASchoolDesignationDescriptor != null && this.TitleIPartASchoolDesignationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TitleIPartASchoolDesignationDescriptor, length must be less than 306.", new [] { "TitleIPartASchoolDesignationDescriptor" });
            }

            yield break;
        }
    }

}
