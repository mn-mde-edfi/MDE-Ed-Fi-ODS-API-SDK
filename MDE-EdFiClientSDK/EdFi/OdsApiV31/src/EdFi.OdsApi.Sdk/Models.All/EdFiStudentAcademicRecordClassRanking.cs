/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface. The Ed-Fi ODS / API supports both transactional and bulk modes of operation.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
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

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// EdFiStudentAcademicRecordClassRanking
    /// </summary>
    [DataContract]
    public partial class EdFiStudentAcademicRecordClassRanking :  IEquatable<EdFiStudentAcademicRecordClassRanking>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAcademicRecordClassRanking" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentAcademicRecordClassRanking() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAcademicRecordClassRanking" /> class.
        /// </summary>
        /// <param name="ClassRank">The academic rank of a student in relation to his or her graduating class (e.g., 1st, 2nd, 3rd). (required).</param>
        /// <param name="ClassRankingDate">Date class ranking was determined..</param>
        /// <param name="PercentageRanking">The academic percentage rank of a student in relation to his or her graduating class (e.g., 95%, 80%, 50%)..</param>
        /// <param name="TotalNumberInClass">The total number of students in the student&#39;s graduating class. (required).</param>
        public EdFiStudentAcademicRecordClassRanking(int? ClassRank = default(int?), DateTime? ClassRankingDate = default(DateTime?), int? PercentageRanking = default(int?), int? TotalNumberInClass = default(int?))
        {
            // to ensure "ClassRank" is required (not null)
            if (ClassRank == null)
            {
                throw new InvalidDataException("ClassRank is a required property for EdFiStudentAcademicRecordClassRanking and cannot be null");
            }
            else
            {
                this.ClassRank = ClassRank;
            }
            // to ensure "TotalNumberInClass" is required (not null)
            if (TotalNumberInClass == null)
            {
                throw new InvalidDataException("TotalNumberInClass is a required property for EdFiStudentAcademicRecordClassRanking and cannot be null");
            }
            else
            {
                this.TotalNumberInClass = TotalNumberInClass;
            }
            this.ClassRankingDate = ClassRankingDate;
            this.PercentageRanking = PercentageRanking;
        }
        
        /// <summary>
        /// The academic rank of a student in relation to his or her graduating class (e.g., 1st, 2nd, 3rd).
        /// </summary>
        /// <value>The academic rank of a student in relation to his or her graduating class (e.g., 1st, 2nd, 3rd).</value>
        [DataMember(Name="classRank", EmitDefaultValue=false)]
        public int? ClassRank { get; set; }

        /// <summary>
        /// Date class ranking was determined.
        /// </summary>
        /// <value>Date class ranking was determined.</value>
        [DataMember(Name="classRankingDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ClassRankingDate { get; set; }

        /// <summary>
        /// The academic percentage rank of a student in relation to his or her graduating class (e.g., 95%, 80%, 50%).
        /// </summary>
        /// <value>The academic percentage rank of a student in relation to his or her graduating class (e.g., 95%, 80%, 50%).</value>
        [DataMember(Name="percentageRanking", EmitDefaultValue=false)]
        public int? PercentageRanking { get; set; }

        /// <summary>
        /// The total number of students in the student&#39;s graduating class.
        /// </summary>
        /// <value>The total number of students in the student&#39;s graduating class.</value>
        [DataMember(Name="totalNumberInClass", EmitDefaultValue=false)]
        public int? TotalNumberInClass { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentAcademicRecordClassRanking {\n");
            sb.Append("  ClassRank: ").Append(ClassRank).Append("\n");
            sb.Append("  ClassRankingDate: ").Append(ClassRankingDate).Append("\n");
            sb.Append("  PercentageRanking: ").Append(PercentageRanking).Append("\n");
            sb.Append("  TotalNumberInClass: ").Append(TotalNumberInClass).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as EdFiStudentAcademicRecordClassRanking);
        }

        /// <summary>
        /// Returns true if EdFiStudentAcademicRecordClassRanking instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentAcademicRecordClassRanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentAcademicRecordClassRanking input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassRank == input.ClassRank ||
                    (this.ClassRank != null &&
                    this.ClassRank.Equals(input.ClassRank))
                ) && 
                (
                    this.ClassRankingDate == input.ClassRankingDate ||
                    (this.ClassRankingDate != null &&
                    this.ClassRankingDate.Equals(input.ClassRankingDate))
                ) && 
                (
                    this.PercentageRanking == input.PercentageRanking ||
                    (this.PercentageRanking != null &&
                    this.PercentageRanking.Equals(input.PercentageRanking))
                ) && 
                (
                    this.TotalNumberInClass == input.TotalNumberInClass ||
                    (this.TotalNumberInClass != null &&
                    this.TotalNumberInClass.Equals(input.TotalNumberInClass))
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
                if (this.ClassRank != null)
                    hashCode = hashCode * 59 + this.ClassRank.GetHashCode();
                if (this.ClassRankingDate != null)
                    hashCode = hashCode * 59 + this.ClassRankingDate.GetHashCode();
                if (this.PercentageRanking != null)
                    hashCode = hashCode * 59 + this.PercentageRanking.GetHashCode();
                if (this.TotalNumberInClass != null)
                    hashCode = hashCode * 59 + this.TotalNumberInClass.GetHashCode();
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