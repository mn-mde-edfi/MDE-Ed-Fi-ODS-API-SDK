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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentParentAssociationReadable
    /// </summary>
    [DataContract(Name = "edFi_studentParentAssociation_readable")]
    public partial class EdFiStudentParentAssociationReadable : IEquatable<EdFiStudentParentAssociationReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentParentAssociationReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentParentAssociationReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentParentAssociationReadable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="parentReference">parentReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="relationDescriptor">The nature of an individual&#39;s relationship to a student, primarily used to capture family relationships..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentParentAssociationReadable(string id = default(string), EdFiParentReference parentReference = default(EdFiParentReference), EdFiStudentReference studentReference = default(EdFiStudentReference), string relationDescriptor = default(string), string etag = default(string))
        {
            // to ensure "parentReference" is required (not null)
            if (parentReference == null)
            {
                throw new ArgumentNullException("parentReference is a required property for EdFiStudentParentAssociationReadable and cannot be null");
            }
            this.ParentReference = parentReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for EdFiStudentParentAssociationReadable and cannot be null");
            }
            this.StudentReference = studentReference;
            this.Id = id;
            this.RelationDescriptor = relationDescriptor;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ParentReference
        /// </summary>
        [DataMember(Name = "parentReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiParentReference ParentReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The nature of an individual&#39;s relationship to a student, primarily used to capture family relationships.
        /// </summary>
        /// <value>The nature of an individual&#39;s relationship to a student, primarily used to capture family relationships.</value>
        [DataMember(Name = "relationDescriptor", EmitDefaultValue = false)]
        public string RelationDescriptor { get; set; }

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
            sb.Append("class EdFiStudentParentAssociationReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentReference: ").Append(ParentReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  RelationDescriptor: ").Append(RelationDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentParentAssociationReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentParentAssociationReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentParentAssociationReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentParentAssociationReadable input)
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
                    this.ParentReference == input.ParentReference ||
                    (this.ParentReference != null &&
                    this.ParentReference.Equals(input.ParentReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.RelationDescriptor == input.RelationDescriptor ||
                    (this.RelationDescriptor != null &&
                    this.RelationDescriptor.Equals(input.RelationDescriptor))
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
                if (this.ParentReference != null)
                {
                    hashCode = (hashCode * 59) + this.ParentReference.GetHashCode();
                }
                if (this.StudentReference != null)
                {
                    hashCode = (hashCode * 59) + this.StudentReference.GetHashCode();
                }
                if (this.RelationDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.RelationDescriptor.GetHashCode();
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
            // RelationDescriptor (string) maxLength
            if (this.RelationDescriptor != null && this.RelationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RelationDescriptor, length must be less than 306.", new [] { "RelationDescriptor" });
            }

            yield break;
        }
    }

}
