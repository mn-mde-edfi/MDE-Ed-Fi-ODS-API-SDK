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
    /// EdFiDisciplineActionDisciplineWritable
    /// </summary>
    [DataContract(Name = "edFi_disciplineActionDiscipline_writable")]
    public partial class EdFiDisciplineActionDisciplineWritable : IEquatable<EdFiDisciplineActionDisciplineWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineActionDisciplineWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiDisciplineActionDisciplineWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineActionDisciplineWritable" /> class.
        /// </summary>
        /// <param name="disciplineDescriptor">Type of action, such as removal from the classroom, used to discipline the student involved as a perpetrator in a discipline incident. (required).</param>
        public EdFiDisciplineActionDisciplineWritable(string disciplineDescriptor = default(string))
        {
            // to ensure "disciplineDescriptor" is required (not null)
            if (disciplineDescriptor == null)
            {
                throw new ArgumentNullException("disciplineDescriptor is a required property for EdFiDisciplineActionDisciplineWritable and cannot be null");
            }
            this.DisciplineDescriptor = disciplineDescriptor;
        }

        /// <summary>
        /// Type of action, such as removal from the classroom, used to discipline the student involved as a perpetrator in a discipline incident.
        /// </summary>
        /// <value>Type of action, such as removal from the classroom, used to discipline the student involved as a perpetrator in a discipline incident.</value>
        [DataMember(Name = "disciplineDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string DisciplineDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiDisciplineActionDisciplineWritable {\n");
            sb.Append("  DisciplineDescriptor: ").Append(DisciplineDescriptor).Append("\n");
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
            return this.Equals(input as EdFiDisciplineActionDisciplineWritable);
        }

        /// <summary>
        /// Returns true if EdFiDisciplineActionDisciplineWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiDisciplineActionDisciplineWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiDisciplineActionDisciplineWritable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisciplineDescriptor == input.DisciplineDescriptor ||
                    (this.DisciplineDescriptor != null &&
                    this.DisciplineDescriptor.Equals(input.DisciplineDescriptor))
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
                if (this.DisciplineDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.DisciplineDescriptor.GetHashCode();
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
            // DisciplineDescriptor (string) maxLength
            if (this.DisciplineDescriptor != null && this.DisciplineDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisciplineDescriptor, length must be less than 306.", new [] { "DisciplineDescriptor" });
            }

            yield break;
        }
    }

}
