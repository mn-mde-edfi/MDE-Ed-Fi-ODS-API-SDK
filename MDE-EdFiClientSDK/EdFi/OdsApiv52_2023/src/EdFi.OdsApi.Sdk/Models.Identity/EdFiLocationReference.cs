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

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiLocationReference
    /// </summary>
    [DataContract]
    public partial class EdFiLocationReference :  IEquatable<EdFiLocationReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocationReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLocationReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocationReference" /> class.
        /// </summary>
        /// <param name="classroomIdentificationCode">A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity. (required).</param>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="link">link.</param>
        public EdFiLocationReference(string classroomIdentificationCode = default(string), int? schoolId = default(int?), Link link = default(Link))
        {
            // to ensure "classroomIdentificationCode" is required (not null)
            if (classroomIdentificationCode == null)
            {
                throw new InvalidDataException("classroomIdentificationCode is a required property for EdFiLocationReference and cannot be null");
            }
            else
            {
                this.ClassroomIdentificationCode = classroomIdentificationCode;
            }
            // to ensure "schoolId" is required (not null)
            if (schoolId == null)
            {
                throw new InvalidDataException("schoolId is a required property for EdFiLocationReference and cannot be null");
            }
            else
            {
                this.SchoolId = schoolId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.</value>
        [DataMember(Name="classroomIdentificationCode", EmitDefaultValue=false)]
        public string ClassroomIdentificationCode { get; set; }

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
            sb.Append("class EdFiLocationReference {\n");
            sb.Append("  ClassroomIdentificationCode: ").Append(ClassroomIdentificationCode).Append("\n");
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
            return this.Equals(input as EdFiLocationReference);
        }

        /// <summary>
        /// Returns true if EdFiLocationReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLocationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLocationReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassroomIdentificationCode == input.ClassroomIdentificationCode ||
                    (this.ClassroomIdentificationCode != null &&
                    this.ClassroomIdentificationCode.Equals(input.ClassroomIdentificationCode))
                ) && 
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
                if (this.ClassroomIdentificationCode != null)
                    hashCode = hashCode * 59 + this.ClassroomIdentificationCode.GetHashCode();
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
