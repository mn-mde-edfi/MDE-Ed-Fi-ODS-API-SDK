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
    /// MnCourseOfferingSiteBasedInitiativeReadable
    /// </summary>
    [DataContract]
    public partial class MnCourseOfferingSiteBasedInitiativeReadable :  IEquatable<MnCourseOfferingSiteBasedInitiativeReadable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseOfferingSiteBasedInitiativeReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnCourseOfferingSiteBasedInitiativeReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseOfferingSiteBasedInitiativeReadable" /> class.
        /// </summary>
        /// <param name="siteBasedInitiativeDescriptor">Site-based initiative. (required).</param>
        /// <param name="implementationStatusDescriptor">Status of implementation of the site-based initiative..</param>
        public MnCourseOfferingSiteBasedInitiativeReadable(string siteBasedInitiativeDescriptor = default(string), string implementationStatusDescriptor = default(string))
        {
            // to ensure "siteBasedInitiativeDescriptor" is required (not null)
            if (siteBasedInitiativeDescriptor == null)
            {
                throw new InvalidDataException("siteBasedInitiativeDescriptor is a required property for MnCourseOfferingSiteBasedInitiativeReadable and cannot be null");
            }
            else
            {
                this.SiteBasedInitiativeDescriptor = siteBasedInitiativeDescriptor;
            }
            this.ImplementationStatusDescriptor = implementationStatusDescriptor;
        }
        
        /// <summary>
        /// Site-based initiative.
        /// </summary>
        /// <value>Site-based initiative.</value>
        [DataMember(Name="siteBasedInitiativeDescriptor", EmitDefaultValue=false)]
        public string SiteBasedInitiativeDescriptor { get; set; }

        /// <summary>
        /// Status of implementation of the site-based initiative.
        /// </summary>
        /// <value>Status of implementation of the site-based initiative.</value>
        [DataMember(Name="implementationStatusDescriptor", EmitDefaultValue=false)]
        public string ImplementationStatusDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnCourseOfferingSiteBasedInitiativeReadable {\n");
            sb.Append("  SiteBasedInitiativeDescriptor: ").Append(SiteBasedInitiativeDescriptor).Append("\n");
            sb.Append("  ImplementationStatusDescriptor: ").Append(ImplementationStatusDescriptor).Append("\n");
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
            return this.Equals(input as MnCourseOfferingSiteBasedInitiativeReadable);
        }

        /// <summary>
        /// Returns true if MnCourseOfferingSiteBasedInitiativeReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCourseOfferingSiteBasedInitiativeReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCourseOfferingSiteBasedInitiativeReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SiteBasedInitiativeDescriptor == input.SiteBasedInitiativeDescriptor ||
                    (this.SiteBasedInitiativeDescriptor != null &&
                    this.SiteBasedInitiativeDescriptor.Equals(input.SiteBasedInitiativeDescriptor))
                ) && 
                (
                    this.ImplementationStatusDescriptor == input.ImplementationStatusDescriptor ||
                    (this.ImplementationStatusDescriptor != null &&
                    this.ImplementationStatusDescriptor.Equals(input.ImplementationStatusDescriptor))
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
                if (this.SiteBasedInitiativeDescriptor != null)
                    hashCode = hashCode * 59 + this.SiteBasedInitiativeDescriptor.GetHashCode();
                if (this.ImplementationStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.ImplementationStatusDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
