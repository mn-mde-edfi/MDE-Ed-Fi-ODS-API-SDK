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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile
{
    /// <summary>
    /// MnStudentEarlyEducationProgramAssociationFundingSourceWritable
    /// </summary>
    [DataContract]
    public partial class MnStudentEarlyEducationProgramAssociationFundingSourceWritable :  IEquatable<MnStudentEarlyEducationProgramAssociationFundingSourceWritable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEarlyEducationProgramAssociationFundingSourceWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentEarlyEducationProgramAssociationFundingSourceWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEarlyEducationProgramAssociationFundingSourceWritable" /> class.
        /// </summary>
        /// <param name="fundingSourceDescriptor">Funding source. (required).</param>
        public MnStudentEarlyEducationProgramAssociationFundingSourceWritable(string fundingSourceDescriptor = default(string))
        {
            // to ensure "fundingSourceDescriptor" is required (not null)
            if (fundingSourceDescriptor == null)
            {
                throw new InvalidDataException("fundingSourceDescriptor is a required property for MnStudentEarlyEducationProgramAssociationFundingSourceWritable and cannot be null");
            }
            else
            {
                this.FundingSourceDescriptor = fundingSourceDescriptor;
            }
        }
        
        /// <summary>
        /// Funding source.
        /// </summary>
        /// <value>Funding source.</value>
        [DataMember(Name="fundingSourceDescriptor", EmitDefaultValue=false)]
        public string FundingSourceDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentEarlyEducationProgramAssociationFundingSourceWritable {\n");
            sb.Append("  FundingSourceDescriptor: ").Append(FundingSourceDescriptor).Append("\n");
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
            return this.Equals(input as MnStudentEarlyEducationProgramAssociationFundingSourceWritable);
        }

        /// <summary>
        /// Returns true if MnStudentEarlyEducationProgramAssociationFundingSourceWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentEarlyEducationProgramAssociationFundingSourceWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentEarlyEducationProgramAssociationFundingSourceWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FundingSourceDescriptor == input.FundingSourceDescriptor ||
                    (this.FundingSourceDescriptor != null &&
                    this.FundingSourceDescriptor.Equals(input.FundingSourceDescriptor))
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
                if (this.FundingSourceDescriptor != null)
                    hashCode = hashCode * 59 + this.FundingSourceDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
