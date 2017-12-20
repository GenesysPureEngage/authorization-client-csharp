/* 
 * Authentication API
 *
 * Authentication API
 *
 * OpenAPI spec version: 9.0.000.00.872
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
    /// AuthSchemeLookupData
    /// </summary>
    [DataContract]
    public partial class AuthSchemeLookupData :  IEquatable<AuthSchemeLookupData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSchemeLookupData" /> class.
        /// </summary>
        /// <param name="Tenant">Tenant.</param>
        /// <param name="UserName">UserName.</param>
        public AuthSchemeLookupData(string Tenant = default(string), string UserName = default(string))
        {
            this.Tenant = Tenant;
            this.UserName = UserName;
        }
        
        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name="tenant", EmitDefaultValue=false)]
        public string Tenant { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthSchemeLookupData {\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as AuthSchemeLookupData);
        }

        /// <summary>
        /// Returns true if AuthSchemeLookupData instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthSchemeLookupData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthSchemeLookupData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
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