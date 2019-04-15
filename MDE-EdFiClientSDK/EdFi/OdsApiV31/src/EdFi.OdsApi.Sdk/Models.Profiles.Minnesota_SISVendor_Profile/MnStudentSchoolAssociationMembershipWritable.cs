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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile
{
    /// <summary>
    /// MnStudentSchoolAssociationMembershipWritable
    /// </summary>
    [DataContract]
    public partial class MnStudentSchoolAssociationMembershipWritable :  IEquatable<MnStudentSchoolAssociationMembershipWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSchoolAssociationMembershipWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentSchoolAssociationMembershipWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSchoolAssociationMembershipWritable" /> class.
        /// </summary>
        /// <param name="MembershipAttendanceUnitDescriptor">Days or Hours. (required).</param>
        /// <param name="Attendance">The total number of Instructional Days or Hours during which students attended school during the current school year. (required).</param>
        /// <param name="Membership">The total number of Instructional Days or Hours during which students were enrolled in the school during the current school year. (required).</param>
        /// <param name="PercentEnrolled">Percent Enrolled (required).</param>
        public MnStudentSchoolAssociationMembershipWritable(string MembershipAttendanceUnitDescriptor = default(string), int? Attendance = default(int?), int? Membership = default(int?), double? PercentEnrolled = default(double?))
        {
            // to ensure "MembershipAttendanceUnitDescriptor" is required (not null)
            if (MembershipAttendanceUnitDescriptor == null)
            {
                throw new InvalidDataException("MembershipAttendanceUnitDescriptor is a required property for MnStudentSchoolAssociationMembershipWritable and cannot be null");
            }
            else
            {
                this.MembershipAttendanceUnitDescriptor = MembershipAttendanceUnitDescriptor;
            }
            // to ensure "Attendance" is required (not null)
            if (Attendance == null)
            {
                throw new InvalidDataException("Attendance is a required property for MnStudentSchoolAssociationMembershipWritable and cannot be null");
            }
            else
            {
                this.Attendance = Attendance;
            }
            // to ensure "Membership" is required (not null)
            if (Membership == null)
            {
                throw new InvalidDataException("Membership is a required property for MnStudentSchoolAssociationMembershipWritable and cannot be null");
            }
            else
            {
                this.Membership = Membership;
            }
            // to ensure "PercentEnrolled" is required (not null)
            if (PercentEnrolled == null)
            {
                throw new InvalidDataException("PercentEnrolled is a required property for MnStudentSchoolAssociationMembershipWritable and cannot be null");
            }
            else
            {
                this.PercentEnrolled = PercentEnrolled;
            }
        }
        
        /// <summary>
        /// Days or Hours.
        /// </summary>
        /// <value>Days or Hours.</value>
        [DataMember(Name="membershipAttendanceUnitDescriptor", EmitDefaultValue=false)]
        public string MembershipAttendanceUnitDescriptor { get; set; }

        /// <summary>
        /// The total number of Instructional Days or Hours during which students attended school during the current school year.
        /// </summary>
        /// <value>The total number of Instructional Days or Hours during which students attended school during the current school year.</value>
        [DataMember(Name="attendance", EmitDefaultValue=false)]
        public int? Attendance { get; set; }

        /// <summary>
        /// The total number of Instructional Days or Hours during which students were enrolled in the school during the current school year.
        /// </summary>
        /// <value>The total number of Instructional Days or Hours during which students were enrolled in the school during the current school year.</value>
        [DataMember(Name="membership", EmitDefaultValue=false)]
        public int? Membership { get; set; }

        /// <summary>
        /// Percent Enrolled
        /// </summary>
        /// <value>Percent Enrolled</value>
        [DataMember(Name="percentEnrolled", EmitDefaultValue=false)]
        public double? PercentEnrolled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentSchoolAssociationMembershipWritable {\n");
            sb.Append("  MembershipAttendanceUnitDescriptor: ").Append(MembershipAttendanceUnitDescriptor).Append("\n");
            sb.Append("  Attendance: ").Append(Attendance).Append("\n");
            sb.Append("  Membership: ").Append(Membership).Append("\n");
            sb.Append("  PercentEnrolled: ").Append(PercentEnrolled).Append("\n");
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
            return this.Equals(input as MnStudentSchoolAssociationMembershipWritable);
        }

        /// <summary>
        /// Returns true if MnStudentSchoolAssociationMembershipWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentSchoolAssociationMembershipWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentSchoolAssociationMembershipWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MembershipAttendanceUnitDescriptor == input.MembershipAttendanceUnitDescriptor ||
                    (this.MembershipAttendanceUnitDescriptor != null &&
                    this.MembershipAttendanceUnitDescriptor.Equals(input.MembershipAttendanceUnitDescriptor))
                ) && 
                (
                    this.Attendance == input.Attendance ||
                    (this.Attendance != null &&
                    this.Attendance.Equals(input.Attendance))
                ) && 
                (
                    this.Membership == input.Membership ||
                    (this.Membership != null &&
                    this.Membership.Equals(input.Membership))
                ) && 
                (
                    this.PercentEnrolled == input.PercentEnrolled ||
                    (this.PercentEnrolled != null &&
                    this.PercentEnrolled.Equals(input.PercentEnrolled))
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
                if (this.MembershipAttendanceUnitDescriptor != null)
                    hashCode = hashCode * 59 + this.MembershipAttendanceUnitDescriptor.GetHashCode();
                if (this.Attendance != null)
                    hashCode = hashCode * 59 + this.Attendance.GetHashCode();
                if (this.Membership != null)
                    hashCode = hashCode * 59 + this.Membership.GetHashCode();
                if (this.PercentEnrolled != null)
                    hashCode = hashCode * 59 + this.PercentEnrolled.GetHashCode();
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
            // MembershipAttendanceUnitDescriptor (string) maxLength
            if(this.MembershipAttendanceUnitDescriptor != null && this.MembershipAttendanceUnitDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MembershipAttendanceUnitDescriptor, length must be less than 306.", new [] { "MembershipAttendanceUnitDescriptor" });
            }

            yield break;
        }
    }

}
