/* 
 * Authentication API
 *
 * Authentication API
 *
 * OpenAPI spec version: 9.0.000.10.1112
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
using SwaggerDateConverter = Genesys.Internal.Authentication.Client.SwaggerDateConverter;

namespace Genesys.Internal.Authentication.Model
{
    /// <summary>
    /// JwtConvertResult
    /// </summary>
    [DataContract]
    public partial class JwtConvertResult :  IEquatable<JwtConvertResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JwtConvertResult" /> class.
        /// </summary>
        /// <param name="JwtToken">JwtToken.</param>
        public JwtConvertResult(string JwtToken = default(string))
        {
            this.JwtToken = JwtToken;
        }
        
        /// <summary>
        /// Gets or Sets JwtToken
        /// </summary>
        [DataMember(Name="jwtToken", EmitDefaultValue=false)]
        public string JwtToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JwtConvertResult {\n");
            sb.Append("  JwtToken: ").Append(JwtToken).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as JwtConvertResult);
        }

        /// <summary>
        /// Returns true if JwtConvertResult instances are equal
        /// </summary>
        /// <param name="input">Instance of JwtConvertResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JwtConvertResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JwtToken == input.JwtToken ||
                    (this.JwtToken != null &&
                    this.JwtToken.Equals(input.JwtToken))
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
                if (this.JwtToken != null)
                    hashCode = hashCode * 59 + this.JwtToken.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}