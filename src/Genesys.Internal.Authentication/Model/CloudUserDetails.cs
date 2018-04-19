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
    /// This class describes the user in the system. Applicable to different entities (contact-center level user, application/service, cloud system admin)
    /// </summary>
    [DataContract]
    public partial class CloudUserDetails :  IEquatable<CloudUserDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudUserDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CloudUserDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudUserDetails" /> class.
        /// </summary>
        /// <param name="Authorities">Authorities assigned to the user. (required).</param>
        /// <param name="CmeUserName">The username in Configuration Server. This property is not set for users who aren&#39;t in Configuration Server (for example, applications/services, cloud system admin and so on.).</param>
        /// <param name="ContactCenterId">The ID of the contact center the user belongs to (if any)..</param>
        /// <param name="Dbid">The DBID of the corresponding user record in Configuration Server. This is present if the user belongs to a contact center..</param>
        /// <param name="EnvironmentId">The ID of the Genesys environment the user belongs to (if any)..</param>
        /// <param name="LoginName">The username in Configuration Server. This property is not set for users who aren&#39;t in Configuration Server (for example, applications/services, cloud system admin and so on.).</param>
        /// <param name="Username">The system-wide unique name of the user. For contact center users, this includes the userName in Configuration Server, the DBID in Configuration Server and the contact center ID. For non-Configuration Server users the username can have other formats. (required).</param>
        public CloudUserDetails(UserRole Authorities = default(UserRole), string CmeUserName = default(string), string ContactCenterId = default(string), int? Dbid = default(int?), string EnvironmentId = default(string), string LoginName = default(string), string Username = default(string))
        {
            // to ensure "Authorities" is required (not null)
            if (Authorities == null)
            {
                throw new InvalidDataException("Authorities is a required property for CloudUserDetails and cannot be null");
            }
            else
            {
                this.Authorities = Authorities;
            }
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for CloudUserDetails and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            this.CmeUserName = CmeUserName;
            this.ContactCenterId = ContactCenterId;
            this.Dbid = Dbid;
            this.EnvironmentId = EnvironmentId;
            this.LoginName = LoginName;
        }
        
        /// <summary>
        /// Authorities assigned to the user.
        /// </summary>
        /// <value>Authorities assigned to the user.</value>
        [DataMember(Name="authorities", EmitDefaultValue=false)]
        public UserRole Authorities { get; set; }

        /// <summary>
        /// The username in Configuration Server. This property is not set for users who aren&#39;t in Configuration Server (for example, applications/services, cloud system admin and so on.)
        /// </summary>
        /// <value>The username in Configuration Server. This property is not set for users who aren&#39;t in Configuration Server (for example, applications/services, cloud system admin and so on.)</value>
        [DataMember(Name="cmeUserName", EmitDefaultValue=false)]
        public string CmeUserName { get; set; }

        /// <summary>
        /// The ID of the contact center the user belongs to (if any).
        /// </summary>
        /// <value>The ID of the contact center the user belongs to (if any).</value>
        [DataMember(Name="contactCenterId", EmitDefaultValue=false)]
        public string ContactCenterId { get; set; }

        /// <summary>
        /// The DBID of the corresponding user record in Configuration Server. This is present if the user belongs to a contact center.
        /// </summary>
        /// <value>The DBID of the corresponding user record in Configuration Server. This is present if the user belongs to a contact center.</value>
        [DataMember(Name="dbid", EmitDefaultValue=false)]
        public int? Dbid { get; set; }

        /// <summary>
        /// The ID of the Genesys environment the user belongs to (if any).
        /// </summary>
        /// <value>The ID of the Genesys environment the user belongs to (if any).</value>
        [DataMember(Name="environmentId", EmitDefaultValue=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// The username in Configuration Server. This property is not set for users who aren&#39;t in Configuration Server (for example, applications/services, cloud system admin and so on.)
        /// </summary>
        /// <value>The username in Configuration Server. This property is not set for users who aren&#39;t in Configuration Server (for example, applications/services, cloud system admin and so on.)</value>
        [DataMember(Name="loginName", EmitDefaultValue=false)]
        public string LoginName { get; set; }

        /// <summary>
        /// The system-wide unique name of the user. For contact center users, this includes the userName in Configuration Server, the DBID in Configuration Server and the contact center ID. For non-Configuration Server users the username can have other formats.
        /// </summary>
        /// <value>The system-wide unique name of the user. For contact center users, this includes the userName in Configuration Server, the DBID in Configuration Server and the contact center ID. For non-Configuration Server users the username can have other formats.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudUserDetails {\n");
            sb.Append("  Authorities: ").Append(Authorities).Append("\n");
            sb.Append("  CmeUserName: ").Append(CmeUserName).Append("\n");
            sb.Append("  ContactCenterId: ").Append(ContactCenterId).Append("\n");
            sb.Append("  Dbid: ").Append(Dbid).Append("\n");
            sb.Append("  EnvironmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("  LoginName: ").Append(LoginName).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as CloudUserDetails);
        }

        /// <summary>
        /// Returns true if CloudUserDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudUserDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudUserDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authorities == input.Authorities ||
                    (this.Authorities != null &&
                    this.Authorities.Equals(input.Authorities))
                ) && 
                (
                    this.CmeUserName == input.CmeUserName ||
                    (this.CmeUserName != null &&
                    this.CmeUserName.Equals(input.CmeUserName))
                ) && 
                (
                    this.ContactCenterId == input.ContactCenterId ||
                    (this.ContactCenterId != null &&
                    this.ContactCenterId.Equals(input.ContactCenterId))
                ) && 
                (
                    this.Dbid == input.Dbid ||
                    (this.Dbid != null &&
                    this.Dbid.Equals(input.Dbid))
                ) && 
                (
                    this.EnvironmentId == input.EnvironmentId ||
                    (this.EnvironmentId != null &&
                    this.EnvironmentId.Equals(input.EnvironmentId))
                ) && 
                (
                    this.LoginName == input.LoginName ||
                    (this.LoginName != null &&
                    this.LoginName.Equals(input.LoginName))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Authorities != null)
                    hashCode = hashCode * 59 + this.Authorities.GetHashCode();
                if (this.CmeUserName != null)
                    hashCode = hashCode * 59 + this.CmeUserName.GetHashCode();
                if (this.ContactCenterId != null)
                    hashCode = hashCode * 59 + this.ContactCenterId.GetHashCode();
                if (this.Dbid != null)
                    hashCode = hashCode * 59 + this.Dbid.GetHashCode();
                if (this.EnvironmentId != null)
                    hashCode = hashCode * 59 + this.EnvironmentId.GetHashCode();
                if (this.LoginName != null)
                    hashCode = hashCode * 59 + this.LoginName.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
