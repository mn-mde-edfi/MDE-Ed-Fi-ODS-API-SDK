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
    /// EdFiPostSecondaryInstitutionWritable
    /// </summary>
    [DataContract]
    public partial class EdFiPostSecondaryInstitutionWritable :  IEquatable<EdFiPostSecondaryInstitutionWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiPostSecondaryInstitutionWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiPostSecondaryInstitutionWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiPostSecondaryInstitutionWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="postSecondaryInstitutionId">The ID of the post secondary institution. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiPostSecondaryInstitutionWritable(string id = default(string), int? postSecondaryInstitutionId = default(int?), string etag = default(string))
        {
            // to ensure "postSecondaryInstitutionId" is required (not null)
            if (postSecondaryInstitutionId == null)
            {
                throw new InvalidDataException("postSecondaryInstitutionId is a required property for EdFiPostSecondaryInstitutionWritable and cannot be null");
            }
            else
            {
                this.PostSecondaryInstitutionId = postSecondaryInstitutionId;
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
        /// The ID of the post secondary institution.
        /// </summary>
        /// <value>The ID of the post secondary institution.</value>
        [DataMember(Name="postSecondaryInstitutionId", EmitDefaultValue=false)]
        public int? PostSecondaryInstitutionId { get; set; }

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
            sb.Append("class EdFiPostSecondaryInstitutionWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PostSecondaryInstitutionId: ").Append(PostSecondaryInstitutionId).Append("\n");
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
            return this.Equals(input as EdFiPostSecondaryInstitutionWritable);
        }

        /// <summary>
        /// Returns true if EdFiPostSecondaryInstitutionWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiPostSecondaryInstitutionWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiPostSecondaryInstitutionWritable input)
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
                    this.PostSecondaryInstitutionId == input.PostSecondaryInstitutionId ||
                    (this.PostSecondaryInstitutionId != null &&
                    this.PostSecondaryInstitutionId.Equals(input.PostSecondaryInstitutionId))
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
                if (this.PostSecondaryInstitutionId != null)
                    hashCode = hashCode * 59 + this.PostSecondaryInstitutionId.GetHashCode();
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
            yield break;
        }
    }

}
