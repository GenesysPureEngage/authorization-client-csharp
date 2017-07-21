/* 
 * Authorization API
 *
 * Authorization API
 *
 * OpenAPI spec version: 9.0.000.00.598
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

namespace Genesys.Authorization.Model
{
    /// <summary>
    /// ApiResponseDomainLookupResult
    /// </summary>
    [DataContract]
    public partial class ApiResponseDomainLookupResult :  IEquatable<ApiResponseDomainLookupResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseDomainLookupResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiResponseDomainLookupResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseDomainLookupResult" /> class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Errors">Errors.</param>
        /// <param name="Path">Path.</param>
        /// <param name="Status">Status (required).</param>
        public ApiResponseDomainLookupResult(DomainLookupResult Data = default(DomainLookupResult), CollectionApiResponseDomainLookupResult Errors = default(CollectionApiResponseDomainLookupResult), string Path = default(string), ApiResponseStatus Status = default(ApiResponseStatus))
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for ApiResponseDomainLookupResult and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            this.Data = Data;
            this.Errors = Errors;
            this.Path = Path;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public DomainLookupResult Data { get; set; }
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public CollectionApiResponseDomainLookupResult Errors { get; set; }
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ApiResponseStatus Status { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseDomainLookupResult {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ApiResponseDomainLookupResult);
        }

        /// <summary>
        /// Returns true if ApiResponseDomainLookupResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiResponseDomainLookupResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseDomainLookupResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.Equals(other.Errors)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
