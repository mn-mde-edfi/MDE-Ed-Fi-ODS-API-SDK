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
    /// MnCourseOfferingExtension
    /// </summary>
    [DataContract]
    public partial class MnCourseOfferingExtension :  IEquatable<MnCourseOfferingExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseOfferingExtension" /> class.
        /// </summary>
        /// <param name="instructionMinutesPerTerm">Instruction minutes per term..</param>
        /// <param name="instructionalApproaches">An unordered collection of courseOfferingInstructionalApproaches. Instructional approach as implemented for the course offering. General purpose but intially implemented for Early Education..</param>
        /// <param name="siteBasedInitiatives">An unordered collection of courseOfferingSiteBasedInitiatives. Site-based initiative as implemented for the course offering. General purpose but intially implemented for Early Education..</param>
        public MnCourseOfferingExtension(int? instructionMinutesPerTerm = default(int?), List<MnCourseOfferingInstructionalApproach> instructionalApproaches = default(List<MnCourseOfferingInstructionalApproach>), List<MnCourseOfferingSiteBasedInitiative> siteBasedInitiatives = default(List<MnCourseOfferingSiteBasedInitiative>))
        {
            this.InstructionMinutesPerTerm = instructionMinutesPerTerm;
            this.InstructionalApproaches = instructionalApproaches;
            this.SiteBasedInitiatives = siteBasedInitiatives;
        }
        
        /// <summary>
        /// Instruction minutes per term.
        /// </summary>
        /// <value>Instruction minutes per term.</value>
        [DataMember(Name="instructionMinutesPerTerm", EmitDefaultValue=false)]
        public int? InstructionMinutesPerTerm { get; set; }

        /// <summary>
        /// An unordered collection of courseOfferingInstructionalApproaches. Instructional approach as implemented for the course offering. General purpose but intially implemented for Early Education.
        /// </summary>
        /// <value>An unordered collection of courseOfferingInstructionalApproaches. Instructional approach as implemented for the course offering. General purpose but intially implemented for Early Education.</value>
        [DataMember(Name="instructionalApproaches", EmitDefaultValue=false)]
        public List<MnCourseOfferingInstructionalApproach> InstructionalApproaches { get; set; }

        /// <summary>
        /// An unordered collection of courseOfferingSiteBasedInitiatives. Site-based initiative as implemented for the course offering. General purpose but intially implemented for Early Education.
        /// </summary>
        /// <value>An unordered collection of courseOfferingSiteBasedInitiatives. Site-based initiative as implemented for the course offering. General purpose but intially implemented for Early Education.</value>
        [DataMember(Name="siteBasedInitiatives", EmitDefaultValue=false)]
        public List<MnCourseOfferingSiteBasedInitiative> SiteBasedInitiatives { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnCourseOfferingExtension {\n");
            sb.Append("  InstructionMinutesPerTerm: ").Append(InstructionMinutesPerTerm).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MnCourseOfferingExtension);
        }

        /// <summary>
        /// Returns true if MnCourseOfferingExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCourseOfferingExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCourseOfferingExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstructionMinutesPerTerm == input.InstructionMinutesPerTerm ||
                    (this.InstructionMinutesPerTerm != null &&
                    this.InstructionMinutesPerTerm.Equals(input.InstructionMinutesPerTerm))
                ) && 
                (
                    this.InstructionalApproaches == input.InstructionalApproaches ||
                    this.InstructionalApproaches != null &&
                    this.InstructionalApproaches.SequenceEqual(input.InstructionalApproaches)
                ) && 
                (
                    this.SiteBasedInitiatives == input.SiteBasedInitiatives ||
                    this.SiteBasedInitiatives != null &&
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
                if (this.InstructionMinutesPerTerm != null)
                    hashCode = hashCode * 59 + this.InstructionMinutesPerTerm.GetHashCode();
                if (this.InstructionalApproaches != null)
                    hashCode = hashCode * 59 + this.InstructionalApproaches.GetHashCode();
                if (this.SiteBasedInitiatives != null)
                    hashCode = hashCode * 59 + this.SiteBasedInitiatives.GetHashCode();
                return hashCode;
            }
        }
    }

}
