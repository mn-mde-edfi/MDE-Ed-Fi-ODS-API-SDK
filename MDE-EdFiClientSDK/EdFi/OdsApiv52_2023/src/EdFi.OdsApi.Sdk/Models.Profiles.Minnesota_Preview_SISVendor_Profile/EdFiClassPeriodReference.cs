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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiClassPeriodReference
    /// </summary>
    [DataContract]
    public partial class EdFiClassPeriodReference :  IEquatable<EdFiClassPeriodReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiClassPeriodReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiClassPeriodReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiClassPeriodReference" /> class.
        /// </summary>
        /// <param name="classPeriodName">An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules). (required).</param>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="link">link.</param>
        public EdFiClassPeriodReference(string classPeriodName = default(string), int? schoolId = default(int?), Link link = default(Link))
        {
            // to ensure "classPeriodName" is required (not null)
            if (classPeriodName == null)
            {
                throw new InvalidDataException("classPeriodName is a required property for EdFiClassPeriodReference and cannot be null");
            }
            else
            {
                this.ClassPeriodName = classPeriodName;
            }
            // to ensure "schoolId" is required (not null)
            if (schoolId == null)
            {
                throw new InvalidDataException("schoolId is a required property for EdFiClassPeriodReference and cannot be null");
            }
            else
            {
                this.SchoolId = schoolId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).
        /// </summary>
        /// <value>An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).</value>
        [DataMember(Name="classPeriodName", EmitDefaultValue=false)]
        public string ClassPeriodName { get; set; }

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
            sb.Append("class EdFiClassPeriodReference {\n");
            sb.Append("  ClassPeriodName: ").Append(ClassPeriodName).Append("\n");
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
            return this.Equals(input as EdFiClassPeriodReference);
        }

        /// <summary>
        /// Returns true if EdFiClassPeriodReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiClassPeriodReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiClassPeriodReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassPeriodName == input.ClassPeriodName ||
                    (this.ClassPeriodName != null &&
                    this.ClassPeriodName.Equals(input.ClassPeriodName))
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
                if (this.ClassPeriodName != null)
                    hashCode = hashCode * 59 + this.ClassPeriodName.GetHashCode();
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
