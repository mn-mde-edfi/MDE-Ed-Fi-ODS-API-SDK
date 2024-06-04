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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile
{
    /// <summary>
    /// MnStudentSchoolAssociationMembershipWritable
    /// </summary>
    [DataContract(Name = "mn_studentSchoolAssociationMembership_writable")]
    public partial class MnStudentSchoolAssociationMembershipWritable : IEquatable<MnStudentSchoolAssociationMembershipWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSchoolAssociationMembershipWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentSchoolAssociationMembershipWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSchoolAssociationMembershipWritable" /> class.
        /// </summary>
        /// <param name="membershipAttendanceUnitDescriptor">Days or Hours. (required).</param>
        /// <param name="attendance">The total number of Instructional Days or Hours during which students attended school during the current school year. (required).</param>
        /// <param name="membership">The total number of Instructional Days or Hours during which students were enrolled in the school during the current school year. (required).</param>
        /// <param name="percentEnrolled">Percent Enrolled (required).</param>
        public MnStudentSchoolAssociationMembershipWritable(string membershipAttendanceUnitDescriptor = default(string), double attendance = default(double), int membership = default(int), int percentEnrolled = default(int))
        {
            // to ensure "membershipAttendanceUnitDescriptor" is required (not null)
            if (membershipAttendanceUnitDescriptor == null)
            {
                throw new ArgumentNullException("membershipAttendanceUnitDescriptor is a required property for MnStudentSchoolAssociationMembershipWritable and cannot be null");
            }
            this.MembershipAttendanceUnitDescriptor = membershipAttendanceUnitDescriptor;
            this.Attendance = attendance;
            this.Membership = membership;
            this.PercentEnrolled = percentEnrolled;
        }

        /// <summary>
        /// Days or Hours.
        /// </summary>
        /// <value>Days or Hours.</value>
        [DataMember(Name = "membershipAttendanceUnitDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string MembershipAttendanceUnitDescriptor { get; set; }

        /// <summary>
        /// The total number of Instructional Days or Hours during which students attended school during the current school year.
        /// </summary>
        /// <value>The total number of Instructional Days or Hours during which students attended school during the current school year.</value>
        [DataMember(Name = "attendance", IsRequired = true, EmitDefaultValue = false)]
        public double Attendance { get; set; }

        /// <summary>
        /// The total number of Instructional Days or Hours during which students were enrolled in the school during the current school year.
        /// </summary>
        /// <value>The total number of Instructional Days or Hours during which students were enrolled in the school during the current school year.</value>
        [DataMember(Name = "membership", IsRequired = true, EmitDefaultValue = false)]
        public int Membership { get; set; }

        /// <summary>
        /// Percent Enrolled
        /// </summary>
        /// <value>Percent Enrolled</value>
        [DataMember(Name = "percentEnrolled", IsRequired = true, EmitDefaultValue = false)]
        public int PercentEnrolled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
            {
                return false;
            }
            return 
                (
                    this.MembershipAttendanceUnitDescriptor == input.MembershipAttendanceUnitDescriptor ||
                    (this.MembershipAttendanceUnitDescriptor != null &&
                    this.MembershipAttendanceUnitDescriptor.Equals(input.MembershipAttendanceUnitDescriptor))
                ) && 
                (
                    this.Attendance == input.Attendance ||
                    this.Attendance.Equals(input.Attendance)
                ) && 
                (
                    this.Membership == input.Membership ||
                    this.Membership.Equals(input.Membership)
                ) && 
                (
                    this.PercentEnrolled == input.PercentEnrolled ||
                    this.PercentEnrolled.Equals(input.PercentEnrolled)
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
                {
                    hashCode = (hashCode * 59) + this.MembershipAttendanceUnitDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Attendance.GetHashCode();
                hashCode = (hashCode * 59) + this.Membership.GetHashCode();
                hashCode = (hashCode * 59) + this.PercentEnrolled.GetHashCode();
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
            // MembershipAttendanceUnitDescriptor (string) maxLength
            if (this.MembershipAttendanceUnitDescriptor != null && this.MembershipAttendanceUnitDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MembershipAttendanceUnitDescriptor, length must be less than 306.", new [] { "MembershipAttendanceUnitDescriptor" });
            }

            yield break;
        }
    }

}
