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
    /// MnGradeExtensionReadable
    /// </summary>
    [DataContract]
    public partial class MnGradeExtensionReadable :  IEquatable<MnGradeExtensionReadable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnGradeExtensionReadable" /> class.
        /// </summary>
        /// <param name="academicSubjectDescriptor">This descriptor holds the description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language)..</param>
        /// <param name="collegeCreditEarned">College credit earned..</param>
        /// <param name="collegeGradeEarned">College grade earned..</param>
        /// <param name="localCreditEarned">College credit earned..</param>
        public MnGradeExtensionReadable(string academicSubjectDescriptor = default(string), double? collegeCreditEarned = default(double?), string collegeGradeEarned = default(string), double? localCreditEarned = default(double?))
        {
            this.AcademicSubjectDescriptor = academicSubjectDescriptor;
            this.CollegeCreditEarned = collegeCreditEarned;
            this.CollegeGradeEarned = collegeGradeEarned;
            this.LocalCreditEarned = localCreditEarned;
        }
        
        /// <summary>
        /// This descriptor holds the description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language).
        /// </summary>
        /// <value>This descriptor holds the description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language).</value>
        [DataMember(Name="academicSubjectDescriptor", EmitDefaultValue=false)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// College credit earned.
        /// </summary>
        /// <value>College credit earned.</value>
        [DataMember(Name="collegeCreditEarned", EmitDefaultValue=false)]
        public double? CollegeCreditEarned { get; set; }

        /// <summary>
        /// College grade earned.
        /// </summary>
        /// <value>College grade earned.</value>
        [DataMember(Name="collegeGradeEarned", EmitDefaultValue=false)]
        public string CollegeGradeEarned { get; set; }

        /// <summary>
        /// College credit earned.
        /// </summary>
        /// <value>College credit earned.</value>
        [DataMember(Name="localCreditEarned", EmitDefaultValue=false)]
        public double? LocalCreditEarned { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnGradeExtensionReadable {\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  CollegeCreditEarned: ").Append(CollegeCreditEarned).Append("\n");
            sb.Append("  CollegeGradeEarned: ").Append(CollegeGradeEarned).Append("\n");
            sb.Append("  LocalCreditEarned: ").Append(LocalCreditEarned).Append("\n");
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
            return this.Equals(input as MnGradeExtensionReadable);
        }

        /// <summary>
        /// Returns true if MnGradeExtensionReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnGradeExtensionReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnGradeExtensionReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
                ) && 
                (
                    this.CollegeCreditEarned == input.CollegeCreditEarned ||
                    (this.CollegeCreditEarned != null &&
                    this.CollegeCreditEarned.Equals(input.CollegeCreditEarned))
                ) && 
                (
                    this.CollegeGradeEarned == input.CollegeGradeEarned ||
                    (this.CollegeGradeEarned != null &&
                    this.CollegeGradeEarned.Equals(input.CollegeGradeEarned))
                ) && 
                (
                    this.LocalCreditEarned == input.LocalCreditEarned ||
                    (this.LocalCreditEarned != null &&
                    this.LocalCreditEarned.Equals(input.LocalCreditEarned))
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
                if (this.AcademicSubjectDescriptor != null)
                    hashCode = hashCode * 59 + this.AcademicSubjectDescriptor.GetHashCode();
                if (this.CollegeCreditEarned != null)
                    hashCode = hashCode * 59 + this.CollegeCreditEarned.GetHashCode();
                if (this.CollegeGradeEarned != null)
                    hashCode = hashCode * 59 + this.CollegeGradeEarned.GetHashCode();
                if (this.LocalCreditEarned != null)
                    hashCode = hashCode * 59 + this.LocalCreditEarned.GetHashCode();
                return hashCode;
            }
        }
    }

}
