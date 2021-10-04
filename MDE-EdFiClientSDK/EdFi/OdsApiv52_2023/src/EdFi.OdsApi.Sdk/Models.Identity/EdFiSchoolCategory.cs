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
    /// EdFiSchoolCategory
    /// </summary>
    [DataContract]
    public partial class EdFiSchoolCategory :  IEquatable<EdFiSchoolCategory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSchoolCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolCategory" /> class.
        /// </summary>
        /// <param name="schoolCategoryDescriptor">The one or more categories of school. For example: High School, Middle School, and/or Elementary School. (required).</param>
        public EdFiSchoolCategory(string schoolCategoryDescriptor = default(string))
        {
            // to ensure "schoolCategoryDescriptor" is required (not null)
            if (schoolCategoryDescriptor == null)
            {
                throw new InvalidDataException("schoolCategoryDescriptor is a required property for EdFiSchoolCategory and cannot be null");
            }
            else
            {
                this.SchoolCategoryDescriptor = schoolCategoryDescriptor;
            }
        }
        
        /// <summary>
        /// The one or more categories of school. For example: High School, Middle School, and/or Elementary School.
        /// </summary>
        /// <value>The one or more categories of school. For example: High School, Middle School, and/or Elementary School.</value>
        [DataMember(Name="schoolCategoryDescriptor", EmitDefaultValue=false)]
        public string SchoolCategoryDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSchoolCategory {\n");
            sb.Append("  SchoolCategoryDescriptor: ").Append(SchoolCategoryDescriptor).Append("\n");
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
            return this.Equals(input as EdFiSchoolCategory);
        }

        /// <summary>
        /// Returns true if EdFiSchoolCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSchoolCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSchoolCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchoolCategoryDescriptor == input.SchoolCategoryDescriptor ||
                    (this.SchoolCategoryDescriptor != null &&
                    this.SchoolCategoryDescriptor.Equals(input.SchoolCategoryDescriptor))
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
                if (this.SchoolCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.SchoolCategoryDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
