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

namespace EdFi.OdsApi.Sdk.Models.Resources
{
    /// <summary>
    /// EdFiAssessmentItem
    /// </summary>
    [DataContract]
    public partial class EdFiAssessmentItem :  IEquatable<EdFiAssessmentItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentItem" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="identificationCode">A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, state, or other agency or entity. (required).</param>
        /// <param name="assessmentReference">assessmentReference (required).</param>
        /// <param name="assessmentItemCategoryDescriptor">Category or type of the AssessmentItem. For example:         Multiple choice         Analytic         Prose         ....</param>
        /// <param name="assessmentItemURI">The URI (typical a URL) pointing to the entry in an assessment item bank, which describes this content item..</param>
        /// <param name="correctResponse">The correct response for the AssessmentItem..</param>
        /// <param name="expectedTimeAssessed">The duration of time allotted for the AssessmentItem..</param>
        /// <param name="itemText">The text of the item..</param>
        /// <param name="learningStandards">An unordered collection of assessmentItemLearningStandards. LearningStandard tested by this item..</param>
        /// <param name="maxRawScore">The maximum raw score achievable across all assessment items that are correct and scored at the maximum..</param>
        /// <param name="nomenclature">Reflects the specific nomenclature used for AssessmentItem..</param>
        /// <param name="possibleResponses">An unordered collection of assessmentItemPossibleResponses. A possible response to an assessment item..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiAssessmentItem(string id = default(string), string identificationCode = default(string), EdFiAssessmentReference assessmentReference = default(EdFiAssessmentReference), string assessmentItemCategoryDescriptor = default(string), string assessmentItemURI = default(string), string correctResponse = default(string), string expectedTimeAssessed = default(string), string itemText = default(string), List<EdFiAssessmentItemLearningStandard> learningStandards = default(List<EdFiAssessmentItemLearningStandard>), double? maxRawScore = default(double?), string nomenclature = default(string), List<EdFiAssessmentItemPossibleResponse> possibleResponses = default(List<EdFiAssessmentItemPossibleResponse>), string etag = default(string))
        {
            // to ensure "identificationCode" is required (not null)
            if (identificationCode == null)
            {
                throw new InvalidDataException("identificationCode is a required property for EdFiAssessmentItem and cannot be null");
            }
            else
            {
                this.IdentificationCode = identificationCode;
            }
            // to ensure "assessmentReference" is required (not null)
            if (assessmentReference == null)
            {
                throw new InvalidDataException("assessmentReference is a required property for EdFiAssessmentItem and cannot be null");
            }
            else
            {
                this.AssessmentReference = assessmentReference;
            }
            this.Id = id;
            this.AssessmentItemCategoryDescriptor = assessmentItemCategoryDescriptor;
            this.AssessmentItemURI = assessmentItemURI;
            this.CorrectResponse = correctResponse;
            this.ExpectedTimeAssessed = expectedTimeAssessed;
            this.ItemText = itemText;
            this.LearningStandards = learningStandards;
            this.MaxRawScore = maxRawScore;
            this.Nomenclature = nomenclature;
            this.PossibleResponses = possibleResponses;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, state, or other agency or entity.</value>
        [DataMember(Name="identificationCode", EmitDefaultValue=false)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Gets or Sets AssessmentReference
        /// </summary>
        [DataMember(Name="assessmentReference", EmitDefaultValue=false)]
        public EdFiAssessmentReference AssessmentReference { get; set; }

        /// <summary>
        /// Category or type of the AssessmentItem. For example:         Multiple choice         Analytic         Prose         ...
        /// </summary>
        /// <value>Category or type of the AssessmentItem. For example:         Multiple choice         Analytic         Prose         ...</value>
        [DataMember(Name="assessmentItemCategoryDescriptor", EmitDefaultValue=false)]
        public string AssessmentItemCategoryDescriptor { get; set; }

        /// <summary>
        /// The URI (typical a URL) pointing to the entry in an assessment item bank, which describes this content item.
        /// </summary>
        /// <value>The URI (typical a URL) pointing to the entry in an assessment item bank, which describes this content item.</value>
        [DataMember(Name="assessmentItemURI", EmitDefaultValue=false)]
        public string AssessmentItemURI { get; set; }

        /// <summary>
        /// The correct response for the AssessmentItem.
        /// </summary>
        /// <value>The correct response for the AssessmentItem.</value>
        [DataMember(Name="correctResponse", EmitDefaultValue=false)]
        public string CorrectResponse { get; set; }

        /// <summary>
        /// The duration of time allotted for the AssessmentItem.
        /// </summary>
        /// <value>The duration of time allotted for the AssessmentItem.</value>
        [DataMember(Name="expectedTimeAssessed", EmitDefaultValue=false)]
        public string ExpectedTimeAssessed { get; set; }

        /// <summary>
        /// The text of the item.
        /// </summary>
        /// <value>The text of the item.</value>
        [DataMember(Name="itemText", EmitDefaultValue=false)]
        public string ItemText { get; set; }

        /// <summary>
        /// An unordered collection of assessmentItemLearningStandards. LearningStandard tested by this item.
        /// </summary>
        /// <value>An unordered collection of assessmentItemLearningStandards. LearningStandard tested by this item.</value>
        [DataMember(Name="learningStandards", EmitDefaultValue=false)]
        public List<EdFiAssessmentItemLearningStandard> LearningStandards { get; set; }

        /// <summary>
        /// The maximum raw score achievable across all assessment items that are correct and scored at the maximum.
        /// </summary>
        /// <value>The maximum raw score achievable across all assessment items that are correct and scored at the maximum.</value>
        [DataMember(Name="maxRawScore", EmitDefaultValue=false)]
        public double? MaxRawScore { get; set; }

        /// <summary>
        /// Reflects the specific nomenclature used for AssessmentItem.
        /// </summary>
        /// <value>Reflects the specific nomenclature used for AssessmentItem.</value>
        [DataMember(Name="nomenclature", EmitDefaultValue=false)]
        public string Nomenclature { get; set; }

        /// <summary>
        /// An unordered collection of assessmentItemPossibleResponses. A possible response to an assessment item.
        /// </summary>
        /// <value>An unordered collection of assessmentItemPossibleResponses. A possible response to an assessment item.</value>
        [DataMember(Name="possibleResponses", EmitDefaultValue=false)]
        public List<EdFiAssessmentItemPossibleResponse> PossibleResponses { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiAssessmentItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
            sb.Append("  AssessmentReference: ").Append(AssessmentReference).Append("\n");
            sb.Append("  AssessmentItemCategoryDescriptor: ").Append(AssessmentItemCategoryDescriptor).Append("\n");
            sb.Append("  AssessmentItemURI: ").Append(AssessmentItemURI).Append("\n");
            sb.Append("  CorrectResponse: ").Append(CorrectResponse).Append("\n");
            sb.Append("  ExpectedTimeAssessed: ").Append(ExpectedTimeAssessed).Append("\n");
            sb.Append("  ItemText: ").Append(ItemText).Append("\n");
            sb.Append("  LearningStandards: ").Append(LearningStandards).Append("\n");
            sb.Append("  MaxRawScore: ").Append(MaxRawScore).Append("\n");
            sb.Append("  Nomenclature: ").Append(Nomenclature).Append("\n");
            sb.Append("  PossibleResponses: ").Append(PossibleResponses).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as EdFiAssessmentItem);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentItem instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IdentificationCode == input.IdentificationCode ||
                    (this.IdentificationCode != null &&
                    this.IdentificationCode.Equals(input.IdentificationCode))
                ) && 
                (
                    this.AssessmentReference == input.AssessmentReference ||
                    (this.AssessmentReference != null &&
                    this.AssessmentReference.Equals(input.AssessmentReference))
                ) && 
                (
                    this.AssessmentItemCategoryDescriptor == input.AssessmentItemCategoryDescriptor ||
                    (this.AssessmentItemCategoryDescriptor != null &&
                    this.AssessmentItemCategoryDescriptor.Equals(input.AssessmentItemCategoryDescriptor))
                ) && 
                (
                    this.AssessmentItemURI == input.AssessmentItemURI ||
                    (this.AssessmentItemURI != null &&
                    this.AssessmentItemURI.Equals(input.AssessmentItemURI))
                ) && 
                (
                    this.CorrectResponse == input.CorrectResponse ||
                    (this.CorrectResponse != null &&
                    this.CorrectResponse.Equals(input.CorrectResponse))
                ) && 
                (
                    this.ExpectedTimeAssessed == input.ExpectedTimeAssessed ||
                    (this.ExpectedTimeAssessed != null &&
                    this.ExpectedTimeAssessed.Equals(input.ExpectedTimeAssessed))
                ) && 
                (
                    this.ItemText == input.ItemText ||
                    (this.ItemText != null &&
                    this.ItemText.Equals(input.ItemText))
                ) && 
                (
                    this.LearningStandards == input.LearningStandards ||
                    this.LearningStandards != null &&
                    this.LearningStandards.SequenceEqual(input.LearningStandards)
                ) && 
                (
                    this.MaxRawScore == input.MaxRawScore ||
                    (this.MaxRawScore != null &&
                    this.MaxRawScore.Equals(input.MaxRawScore))
                ) && 
                (
                    this.Nomenclature == input.Nomenclature ||
                    (this.Nomenclature != null &&
                    this.Nomenclature.Equals(input.Nomenclature))
                ) && 
                (
                    this.PossibleResponses == input.PossibleResponses ||
                    this.PossibleResponses != null &&
                    this.PossibleResponses.SequenceEqual(input.PossibleResponses)
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IdentificationCode != null)
                    hashCode = hashCode * 59 + this.IdentificationCode.GetHashCode();
                if (this.AssessmentReference != null)
                    hashCode = hashCode * 59 + this.AssessmentReference.GetHashCode();
                if (this.AssessmentItemCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentItemCategoryDescriptor.GetHashCode();
                if (this.AssessmentItemURI != null)
                    hashCode = hashCode * 59 + this.AssessmentItemURI.GetHashCode();
                if (this.CorrectResponse != null)
                    hashCode = hashCode * 59 + this.CorrectResponse.GetHashCode();
                if (this.ExpectedTimeAssessed != null)
                    hashCode = hashCode * 59 + this.ExpectedTimeAssessed.GetHashCode();
                if (this.ItemText != null)
                    hashCode = hashCode * 59 + this.ItemText.GetHashCode();
                if (this.LearningStandards != null)
                    hashCode = hashCode * 59 + this.LearningStandards.GetHashCode();
                if (this.MaxRawScore != null)
                    hashCode = hashCode * 59 + this.MaxRawScore.GetHashCode();
                if (this.Nomenclature != null)
                    hashCode = hashCode * 59 + this.Nomenclature.GetHashCode();
                if (this.PossibleResponses != null)
                    hashCode = hashCode * 59 + this.PossibleResponses.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
