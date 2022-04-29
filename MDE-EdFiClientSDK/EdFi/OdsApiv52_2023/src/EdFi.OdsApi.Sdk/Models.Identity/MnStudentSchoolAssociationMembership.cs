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

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// MnStudentSchoolAssociationMembership
    /// </summary>
    [DataContract]
    public partial class MnStudentSchoolAssociationMembership :  IEquatable<MnStudentSchoolAssociationMembership>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSchoolAssociationMembership" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentSchoolAssociationMembership() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSchoolAssociationMembership" /> class.
        /// </summary>
        /// <param name="membershipAttendanceUnitDescriptor">Days or Hours. (required).</param>
        /// <param name="attendance">The total number of Instructional Days or Hours during which students attended school during the current school year. (required).</param>
        /// <param name="membership">The total number of Instructional Days or Hours during which students were enrolled in the school during the current school year. (required).</param>
        /// <param name="percentEnrolled">Percent Enrolled (required).</param>
        public MnStudentSchoolAssociationMembership(string membershipAttendanceUnitDescriptor = default(string), double? attendance = default(double?), int? membership = default(int?), int? percentEnrolled = default(int?))
        {
            // to ensure "membershipAttendanceUnitDescriptor" is required (not null)
            if (membershipAttendanceUnitDescriptor == null)
            {
                throw new InvalidDataException("membershipAttendanceUnitDescriptor is a required property for MnStudentSchoolAssociationMembership and cannot be null");
            }
            else
            {
                this.MembershipAttendanceUnitDescriptor = membershipAttendanceUnitDescriptor;
            }
            // to ensure "attendance" is required (not null)
            if (attendance == null)
            {
                throw new InvalidDataException("attendance is a required property for MnStudentSchoolAssociationMembership and cannot be null");
            }
            else
            {
                this.Attendance = attendance;
            }
            // to ensure "membership" is required (not null)
            if (membership == null)
            {
                throw new InvalidDataException("membership is a required property for MnStudentSchoolAssociationMembership and cannot be null");
            }
            else
            {
                this.Membership = membership;
            }
            // to ensure "percentEnrolled" is required (not null)
            if (percentEnrolled == null)
            {
                throw new InvalidDataException("percentEnrolled is a required property for MnStudentSchoolAssociationMembership and cannot be null");
            }
            else
            {
                this.PercentEnrolled = percentEnrolled;
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
        public double? Attendance { get; set; }

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
        public int? PercentEnrolled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentSchoolAssociationMembership {\n");
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
            return this.Equals(input as MnStudentSchoolAssociationMembership);
        }

        /// <summary>
        /// Returns true if MnStudentSchoolAssociationMembership instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentSchoolAssociationMembership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentSchoolAssociationMembership input)
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
