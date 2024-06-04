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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// MnCourseCourseAssociationWritable
    /// </summary>
    [DataContract(Name = "mn_courseCourseAssociation_writable")]
    public partial class MnCourseCourseAssociationWritable : IEquatable<MnCourseCourseAssociationWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseCourseAssociationWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnCourseCourseAssociationWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseCourseAssociationWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="courseReference">courseReference (required).</param>
        /// <param name="toCourseReference">toCourseReference (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public MnCourseCourseAssociationWritable(string id = default(string), MnCourseReference courseReference = default(MnCourseReference), MnCourseReference toCourseReference = default(MnCourseReference), string etag = default(string))
        {
            // to ensure "courseReference" is required (not null)
            if (courseReference == null)
            {
                throw new ArgumentNullException("courseReference is a required property for MnCourseCourseAssociationWritable and cannot be null");
            }
            this.CourseReference = courseReference;
            // to ensure "toCourseReference" is required (not null)
            if (toCourseReference == null)
            {
                throw new ArgumentNullException("toCourseReference is a required property for MnCourseCourseAssociationWritable and cannot be null");
            }
            this.ToCourseReference = toCourseReference;
            this.Id = id;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CourseReference
        /// </summary>
        [DataMember(Name = "courseReference", IsRequired = true, EmitDefaultValue = false)]
        public MnCourseReference CourseReference { get; set; }

        /// <summary>
        /// Gets or Sets ToCourseReference
        /// </summary>
        [DataMember(Name = "toCourseReference", IsRequired = true, EmitDefaultValue = false)]
        public MnCourseReference ToCourseReference { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnCourseCourseAssociationWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CourseReference: ").Append(CourseReference).Append("\n");
            sb.Append("  ToCourseReference: ").Append(ToCourseReference).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MnCourseCourseAssociationWritable);
        }

        /// <summary>
        /// Returns true if MnCourseCourseAssociationWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCourseCourseAssociationWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCourseCourseAssociationWritable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CourseReference == input.CourseReference ||
                    (this.CourseReference != null &&
                    this.CourseReference.Equals(input.CourseReference))
                ) && 
                (
                    this.ToCourseReference == input.ToCourseReference ||
                    (this.ToCourseReference != null &&
                    this.ToCourseReference.Equals(input.ToCourseReference))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.CourseReference != null)
                {
                    hashCode = (hashCode * 59) + this.CourseReference.GetHashCode();
                }
                if (this.ToCourseReference != null)
                {
                    hashCode = (hashCode * 59) + this.ToCourseReference.GetHashCode();
                }
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
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
            yield break;
        }
    }

}