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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Three_Twenty_Four_SISVendor_Profile
{
    /// <summary>
    /// MnCourseOfferingExtensionWritable
    /// </summary>
    [DataContract(Name = "mn_courseOfferingExtension_writable")]
    public partial class MnCourseOfferingExtensionWritable : IEquatable<MnCourseOfferingExtensionWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseOfferingExtensionWritable" /> class.
        /// </summary>
        /// <param name="instructionalApproaches">An unordered collection of courseOfferingInstructionalApproaches. Instructional approach as implemented for the course offering. General purpose but intially implemented for Early Education..</param>
        /// <param name="siteBasedInitiatives">An unordered collection of courseOfferingSiteBasedInitiatives. Site-based initiative as implemented for the course offering. General purpose but intially implemented for Early Education..</param>
        public MnCourseOfferingExtensionWritable(List<MnCourseOfferingInstructionalApproachWritable> instructionalApproaches = default(List<MnCourseOfferingInstructionalApproachWritable>), List<MnCourseOfferingSiteBasedInitiativeWritable> siteBasedInitiatives = default(List<MnCourseOfferingSiteBasedInitiativeWritable>))
        {
            this.InstructionalApproaches = instructionalApproaches;
            this.SiteBasedInitiatives = siteBasedInitiatives;
        }

        /// <summary>
        /// An unordered collection of courseOfferingInstructionalApproaches. Instructional approach as implemented for the course offering. General purpose but intially implemented for Early Education.
        /// </summary>
        /// <value>An unordered collection of courseOfferingInstructionalApproaches. Instructional approach as implemented for the course offering. General purpose but intially implemented for Early Education.</value>
        [DataMember(Name = "instructionalApproaches", EmitDefaultValue = false)]
        public List<MnCourseOfferingInstructionalApproachWritable> InstructionalApproaches { get; set; }

        /// <summary>
        /// An unordered collection of courseOfferingSiteBasedInitiatives. Site-based initiative as implemented for the course offering. General purpose but intially implemented for Early Education.
        /// </summary>
        /// <value>An unordered collection of courseOfferingSiteBasedInitiatives. Site-based initiative as implemented for the course offering. General purpose but intially implemented for Early Education.</value>
        [DataMember(Name = "siteBasedInitiatives", EmitDefaultValue = false)]
        public List<MnCourseOfferingSiteBasedInitiativeWritable> SiteBasedInitiatives { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnCourseOfferingExtensionWritable {\n");
            sb.Append("  InstructionalApproaches: ").Append(InstructionalApproaches).Append("\n");
            sb.Append("  SiteBasedInitiatives: ").Append(SiteBasedInitiatives).Append("\n");
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
            return this.Equals(input as MnCourseOfferingExtensionWritable);
        }

        /// <summary>
        /// Returns true if MnCourseOfferingExtensionWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCourseOfferingExtensionWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCourseOfferingExtensionWritable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstructionalApproaches == input.InstructionalApproaches ||
                    this.InstructionalApproaches != null &&
                    input.InstructionalApproaches != null &&
                    this.InstructionalApproaches.SequenceEqual(input.InstructionalApproaches)
                ) && 
                (
                    this.SiteBasedInitiatives == input.SiteBasedInitiatives ||
                    this.SiteBasedInitiatives != null &&
                    input.SiteBasedInitiatives != null &&
                    this.SiteBasedInitiatives.SequenceEqual(input.SiteBasedInitiatives)
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
                if (this.InstructionalApproaches != null)
                {
                    hashCode = (hashCode * 59) + this.InstructionalApproaches.GetHashCode();
                }
                if (this.SiteBasedInitiatives != null)
                {
                    hashCode = (hashCode * 59) + this.SiteBasedInitiatives.GetHashCode();
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
            yield break;
        }
    }

}
