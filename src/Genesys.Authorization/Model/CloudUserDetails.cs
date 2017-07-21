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
        /// <param name="Authorities">Authorities assigned to user (required).</param>
        /// <param name="CmeUserName">The user name in CME. Not set for users which are not in CME (applications, cloud system admin,...).</param>
        /// <param name="ContactCenterId">Id of contact center user belongs to (if any).</param>
        /// <param name="Dbid">DBID of user record in corresponding CME (present iff user belongs to contact center).</param>
        /// <param name="EnvironmentId">Id of genesys environment user belongs to (if any).</param>
        /// <param name="LoginName">The user name in CME. Not set for users which are not in CME (applications, cloud system admin,...).</param>
        /// <param name="Username">System-wide-unique name of user in the system. For contact-center user it includes CME userName , dbid in CME and cc id. For Non-cme users, this can have other formats (required).</param>
        public CloudUserDetails(CollectionUserRole Authorities = default(CollectionUserRole), string CmeUserName = default(string), string ContactCenterId = default(string), int? Dbid = default(int?), string EnvironmentId = default(string), string LoginName = default(string), string Username = default(string))
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
        /// Authorities assigned to user
        /// </summary>
        /// <value>Authorities assigned to user</value>
        [DataMember(Name="authorities", EmitDefaultValue=false)]
        public CollectionUserRole Authorities { get; set; }
        /// <summary>
        /// The user name in CME. Not set for users which are not in CME (applications, cloud system admin,...)
        /// </summary>
        /// <value>The user name in CME. Not set for users which are not in CME (applications, cloud system admin,...)</value>
        [DataMember(Name="cmeUserName", EmitDefaultValue=false)]
        public string CmeUserName { get; set; }
        /// <summary>
        /// Id of contact center user belongs to (if any)
        /// </summary>
        /// <value>Id of contact center user belongs to (if any)</value>
        [DataMember(Name="contactCenterId", EmitDefaultValue=false)]
        public string ContactCenterId { get; set; }
        /// <summary>
        /// DBID of user record in corresponding CME (present iff user belongs to contact center)
        /// </summary>
        /// <value>DBID of user record in corresponding CME (present iff user belongs to contact center)</value>
        [DataMember(Name="dbid", EmitDefaultValue=false)]
        public int? Dbid { get; set; }
        /// <summary>
        /// Id of genesys environment user belongs to (if any)
        /// </summary>
        /// <value>Id of genesys environment user belongs to (if any)</value>
        [DataMember(Name="environmentId", EmitDefaultValue=false)]
        public string EnvironmentId { get; set; }
        /// <summary>
        /// The user name in CME. Not set for users which are not in CME (applications, cloud system admin,...)
        /// </summary>
        /// <value>The user name in CME. Not set for users which are not in CME (applications, cloud system admin,...)</value>
        [DataMember(Name="loginName", EmitDefaultValue=false)]
        public string LoginName { get; set; }
        /// <summary>
        /// System-wide-unique name of user in the system. For contact-center user it includes CME userName , dbid in CME and cc id. For Non-cme users, this can have other formats
        /// </summary>
        /// <value>System-wide-unique name of user in the system. For contact-center user it includes CME userName , dbid in CME and cc id. For Non-cme users, this can have other formats</value>
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CloudUserDetails);
        }

        /// <summary>
        /// Returns true if CloudUserDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of CloudUserDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudUserDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Authorities == other.Authorities ||
                    this.Authorities != null &&
                    this.Authorities.Equals(other.Authorities)
                ) && 
                (
                    this.CmeUserName == other.CmeUserName ||
                    this.CmeUserName != null &&
                    this.CmeUserName.Equals(other.CmeUserName)
                ) && 
                (
                    this.ContactCenterId == other.ContactCenterId ||
                    this.ContactCenterId != null &&
                    this.ContactCenterId.Equals(other.ContactCenterId)
                ) && 
                (
                    this.Dbid == other.Dbid ||
                    this.Dbid != null &&
                    this.Dbid.Equals(other.Dbid)
                ) && 
                (
                    this.EnvironmentId == other.EnvironmentId ||
                    this.EnvironmentId != null &&
                    this.EnvironmentId.Equals(other.EnvironmentId)
                ) && 
                (
                    this.LoginName == other.LoginName ||
                    this.LoginName != null &&
                    this.LoginName.Equals(other.LoginName)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
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
                if (this.Authorities != null)
                    hash = hash * 59 + this.Authorities.GetHashCode();
                if (this.CmeUserName != null)
                    hash = hash * 59 + this.CmeUserName.GetHashCode();
                if (this.ContactCenterId != null)
                    hash = hash * 59 + this.ContactCenterId.GetHashCode();
                if (this.Dbid != null)
                    hash = hash * 59 + this.Dbid.GetHashCode();
                if (this.EnvironmentId != null)
                    hash = hash * 59 + this.EnvironmentId.GetHashCode();
                if (this.LoginName != null)
                    hash = hash * 59 + this.LoginName.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
