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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyOne_TwentyTwo_SISVendor_Profile
{
    /// <summary>
    /// EdFiParentWritable
    /// </summary>
    [DataContract]
    public partial class EdFiParentWritable :  IEquatable<EdFiParentWritable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParentWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiParentWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParentWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="parentUniqueId">A unique alphanumeric code assigned to a parent. (required).</param>
        /// <param name="firstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (required).</param>
        /// <param name="generationCodeSuffix">An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III)..</param>
        /// <param name="highestCompletedLevelOfEducationDescriptor">The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received)..</param>
        /// <param name="lastSurname">The name borne in common by members of a family. (required).</param>
        /// <param name="middleName">A secondary name given to an individual at birth, baptism, or during another naming ceremony..</param>
        /// <param name="sexDescriptor">A person&#39;s gender..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiParentWritable(string id = default(string), string parentUniqueId = default(string), string firstName = default(string), string generationCodeSuffix = default(string), string highestCompletedLevelOfEducationDescriptor = default(string), string lastSurname = default(string), string middleName = default(string), string sexDescriptor = default(string), string etag = default(string), ParentExtensionsWritable ext = default(ParentExtensionsWritable))
        {
            // to ensure "parentUniqueId" is required (not null)
            if (parentUniqueId == null)
            {
                throw new InvalidDataException("parentUniqueId is a required property for EdFiParentWritable and cannot be null");
            }
            else
            {
                this.ParentUniqueId = parentUniqueId;
            }
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for EdFiParentWritable and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastSurname" is required (not null)
            if (lastSurname == null)
            {
                throw new InvalidDataException("lastSurname is a required property for EdFiParentWritable and cannot be null");
            }
            else
            {
                this.LastSurname = lastSurname;
            }
            this.Id = id;
            this.GenerationCodeSuffix = generationCodeSuffix;
            this.HighestCompletedLevelOfEducationDescriptor = highestCompletedLevelOfEducationDescriptor;
            this.MiddleName = middleName;
            this.SexDescriptor = sexDescriptor;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a parent.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a parent.</value>
        [DataMember(Name="parentUniqueId", EmitDefaultValue=false)]
        public string ParentUniqueId { get; set; }

        /// <summary>
        /// A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.
        /// </summary>
        /// <value>A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III).
        /// </summary>
        /// <value>An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III).</value>
        [DataMember(Name="generationCodeSuffix", EmitDefaultValue=false)]
        public string GenerationCodeSuffix { get; set; }

        /// <summary>
        /// The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        /// <value>The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).</value>
        [DataMember(Name="highestCompletedLevelOfEducationDescriptor", EmitDefaultValue=false)]
        public string HighestCompletedLevelOfEducationDescriptor { get; set; }

        /// <summary>
        /// The name borne in common by members of a family.
        /// </summary>
        /// <value>The name borne in common by members of a family.</value>
        [DataMember(Name="lastSurname", EmitDefaultValue=false)]
        public string LastSurname { get; set; }

        /// <summary>
        /// A secondary name given to an individual at birth, baptism, or during another naming ceremony.
        /// </summary>
        /// <value>A secondary name given to an individual at birth, baptism, or during another naming ceremony.</value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// A person&#39;s gender.
        /// </summary>
        /// <value>A person&#39;s gender.</value>
        [DataMember(Name="sexDescriptor", EmitDefaultValue=false)]
        public string SexDescriptor { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="_ext", EmitDefaultValue=false)]
        public ParentExtensionsWritable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiParentWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentUniqueId: ").Append(ParentUniqueId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  GenerationCodeSuffix: ").Append(GenerationCodeSuffix).Append("\n");
            sb.Append("  HighestCompletedLevelOfEducationDescriptor: ").Append(HighestCompletedLevelOfEducationDescriptor).Append("\n");
            sb.Append("  LastSurname: ").Append(LastSurname).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  SexDescriptor: ").Append(SexDescriptor).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            return this.Equals(input as EdFiParentWritable);
        }

        /// <summary>
        /// Returns true if EdFiParentWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiParentWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiParentWritable input)
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
                    this.ParentUniqueId == input.ParentUniqueId ||
                    (this.ParentUniqueId != null &&
                    this.ParentUniqueId.Equals(input.ParentUniqueId))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.GenerationCodeSuffix == input.GenerationCodeSuffix ||
                    (this.GenerationCodeSuffix != null &&
                    this.GenerationCodeSuffix.Equals(input.GenerationCodeSuffix))
                ) && 
                (
                    this.HighestCompletedLevelOfEducationDescriptor == input.HighestCompletedLevelOfEducationDescriptor ||
                    (this.HighestCompletedLevelOfEducationDescriptor != null &&
                    this.HighestCompletedLevelOfEducationDescriptor.Equals(input.HighestCompletedLevelOfEducationDescriptor))
                ) && 
                (
                    this.LastSurname == input.LastSurname ||
                    (this.LastSurname != null &&
                    this.LastSurname.Equals(input.LastSurname))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.SexDescriptor == input.SexDescriptor ||
                    (this.SexDescriptor != null &&
                    this.SexDescriptor.Equals(input.SexDescriptor))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
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
                if (this.ParentUniqueId != null)
                    hashCode = hashCode * 59 + this.ParentUniqueId.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.GenerationCodeSuffix != null)
                    hashCode = hashCode * 59 + this.GenerationCodeSuffix.GetHashCode();
                if (this.HighestCompletedLevelOfEducationDescriptor != null)
                    hashCode = hashCode * 59 + this.HighestCompletedLevelOfEducationDescriptor.GetHashCode();
                if (this.LastSurname != null)
                    hashCode = hashCode * 59 + this.LastSurname.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.SexDescriptor != null)
                    hashCode = hashCode * 59 + this.SexDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
