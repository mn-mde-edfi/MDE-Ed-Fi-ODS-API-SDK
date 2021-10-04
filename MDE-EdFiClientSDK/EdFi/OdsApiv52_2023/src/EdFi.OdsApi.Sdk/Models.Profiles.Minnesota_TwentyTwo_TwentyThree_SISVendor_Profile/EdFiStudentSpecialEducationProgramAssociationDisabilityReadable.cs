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
    /// EdFiStudentSpecialEducationProgramAssociationDisabilityReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentSpecialEducationProgramAssociationDisabilityReadable :  IEquatable<EdFiStudentSpecialEducationProgramAssociationDisabilityReadable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSpecialEducationProgramAssociationDisabilityReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSpecialEducationProgramAssociationDisabilityReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSpecialEducationProgramAssociationDisabilityReadable" /> class.
        /// </summary>
        /// <param name="disabilityDescriptor">A disability category that describes a child&#39;s impairment. (required).</param>
        /// <param name="orderOfDisability">The order by severity of student&#39;s disabilities: 1- Primary, 2 -  Secondary, 3 - Tertiary, etc..</param>
        public EdFiStudentSpecialEducationProgramAssociationDisabilityReadable(string disabilityDescriptor = default(string), int? orderOfDisability = default(int?))
        {
            // to ensure "disabilityDescriptor" is required (not null)
            if (disabilityDescriptor == null)
            {
                throw new InvalidDataException("disabilityDescriptor is a required property for EdFiStudentSpecialEducationProgramAssociationDisabilityReadable and cannot be null");
            }
            else
            {
                this.DisabilityDescriptor = disabilityDescriptor;
            }
            this.OrderOfDisability = orderOfDisability;
        }
        
        /// <summary>
        /// A disability category that describes a child&#39;s impairment.
        /// </summary>
        /// <value>A disability category that describes a child&#39;s impairment.</value>
        [DataMember(Name="disabilityDescriptor", EmitDefaultValue=false)]
        public string DisabilityDescriptor { get; set; }

        /// <summary>
        /// The order by severity of student&#39;s disabilities: 1- Primary, 2 -  Secondary, 3 - Tertiary, etc.
        /// </summary>
        /// <value>The order by severity of student&#39;s disabilities: 1- Primary, 2 -  Secondary, 3 - Tertiary, etc.</value>
        [DataMember(Name="orderOfDisability", EmitDefaultValue=false)]
        public int? OrderOfDisability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentSpecialEducationProgramAssociationDisabilityReadable {\n");
            sb.Append("  DisabilityDescriptor: ").Append(DisabilityDescriptor).Append("\n");
            sb.Append("  OrderOfDisability: ").Append(OrderOfDisability).Append("\n");
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
            return this.Equals(input as EdFiStudentSpecialEducationProgramAssociationDisabilityReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentSpecialEducationProgramAssociationDisabilityReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSpecialEducationProgramAssociationDisabilityReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSpecialEducationProgramAssociationDisabilityReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisabilityDescriptor == input.DisabilityDescriptor ||
                    (this.DisabilityDescriptor != null &&
                    this.DisabilityDescriptor.Equals(input.DisabilityDescriptor))
                ) && 
                (
                    this.OrderOfDisability == input.OrderOfDisability ||
                    (this.OrderOfDisability != null &&
                    this.OrderOfDisability.Equals(input.OrderOfDisability))
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
                if (this.DisabilityDescriptor != null)
                    hashCode = hashCode * 59 + this.DisabilityDescriptor.GetHashCode();
                if (this.OrderOfDisability != null)
                    hashCode = hashCode * 59 + this.OrderOfDisability.GetHashCode();
                return hashCode;
            }
        }
    }

}
