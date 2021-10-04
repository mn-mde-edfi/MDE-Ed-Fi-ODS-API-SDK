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
    /// MnSessionExtension
    /// </summary>
    [DataContract]
    public partial class MnSessionExtension :  IEquatable<MnSessionExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnSessionExtension" /> class.
        /// </summary>
        /// <param name="daysInSession">Total days in session..</param>
        /// <param name="termNumber">Term number..</param>
        public MnSessionExtension(double? daysInSession = default(double?), int? termNumber = default(int?))
        {
            this.DaysInSession = daysInSession;
            this.TermNumber = termNumber;
        }
        
        /// <summary>
        /// Total days in session.
        /// </summary>
        /// <value>Total days in session.</value>
        [DataMember(Name="daysInSession", EmitDefaultValue=false)]
        public double? DaysInSession { get; set; }

        /// <summary>
        /// Term number.
        /// </summary>
        /// <value>Term number.</value>
        [DataMember(Name="termNumber", EmitDefaultValue=false)]
        public int? TermNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnSessionExtension {\n");
            sb.Append("  DaysInSession: ").Append(DaysInSession).Append("\n");
            sb.Append("  TermNumber: ").Append(TermNumber).Append("\n");
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
            return this.Equals(input as MnSessionExtension);
        }

        /// <summary>
        /// Returns true if MnSessionExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of MnSessionExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnSessionExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DaysInSession == input.DaysInSession ||
                    (this.DaysInSession != null &&
                    this.DaysInSession.Equals(input.DaysInSession))
                ) && 
                (
                    this.TermNumber == input.TermNumber ||
                    (this.TermNumber != null &&
                    this.TermNumber.Equals(input.TermNumber))
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
                if (this.DaysInSession != null)
                    hashCode = hashCode * 59 + this.DaysInSession.GetHashCode();
                if (this.TermNumber != null)
                    hashCode = hashCode * 59 + this.TermNumber.GetHashCode();
                return hashCode;
            }
        }
    }

}
