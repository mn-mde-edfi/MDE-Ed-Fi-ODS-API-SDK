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
    /// EdFiLearningObjectiveGradeLevel
    /// </summary>
    [DataContract]
    public partial class EdFiLearningObjectiveGradeLevel :  IEquatable<EdFiLearningObjectiveGradeLevel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningObjectiveGradeLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLearningObjectiveGradeLevel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningObjectiveGradeLevel" /> class.
        /// </summary>
        /// <param name="gradeLevelDescriptor">The grade level for which the LearningObjective is targeted. The semantics of null is assumed to mean that the learning objective is not associated with any grade level. (required).</param>
        public EdFiLearningObjectiveGradeLevel(string gradeLevelDescriptor = default(string))
        {
            // to ensure "gradeLevelDescriptor" is required (not null)
            if (gradeLevelDescriptor == null)
            {
                throw new InvalidDataException("gradeLevelDescriptor is a required property for EdFiLearningObjectiveGradeLevel and cannot be null");
            }
            else
            {
                this.GradeLevelDescriptor = gradeLevelDescriptor;
            }
        }
        
        /// <summary>
        /// The grade level for which the LearningObjective is targeted. The semantics of null is assumed to mean that the learning objective is not associated with any grade level.
        /// </summary>
        /// <value>The grade level for which the LearningObjective is targeted. The semantics of null is assumed to mean that the learning objective is not associated with any grade level.</value>
        [DataMember(Name="gradeLevelDescriptor", EmitDefaultValue=false)]
        public string GradeLevelDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiLearningObjectiveGradeLevel {\n");
            sb.Append("  GradeLevelDescriptor: ").Append(GradeLevelDescriptor).Append("\n");
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
            return this.Equals(input as EdFiLearningObjectiveGradeLevel);
        }

        /// <summary>
        /// Returns true if EdFiLearningObjectiveGradeLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLearningObjectiveGradeLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLearningObjectiveGradeLevel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GradeLevelDescriptor == input.GradeLevelDescriptor ||
                    (this.GradeLevelDescriptor != null &&
                    this.GradeLevelDescriptor.Equals(input.GradeLevelDescriptor))
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
                if (this.GradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.GradeLevelDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
