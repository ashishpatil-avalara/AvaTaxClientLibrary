/* 
 * AvaTax API
 *
 * REST interface to Avalara's enterprise tax service, AvaTax.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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

namespace Avalara.AvaTax.RestClient.Model
{
    /// <summary>
    /// This object is used to keep track of custom information about a company.              A setting can refer to any type of data you need to remember about this company object.              When creating this object, you may define your own \&quot;set\&quot;, \&quot;name\&quot;, and \&quot;value\&quot; parameters.              To define your own values, please choose a \&quot;set\&quot; name that begins with \&quot;X-\&quot; to indicate an extension.
    /// </summary>
    [DataContract]
    public partial class SettingModel :  IEquatable<SettingModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SettingModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingModel" /> class.
        /// </summary>
        /// <param name="Set">A user-defined \&quot;set\&quot; containing this name-value pair. (required).</param>
        /// <param name="Name">A user-defined \&quot;name\&quot; for this name-value pair. (required).</param>
        /// <param name="Value">The value of this name-value pair..</param>
        public SettingModel(string Set = null, string Name = null, string Value = null)
        {
            // to ensure "Set" is required (not null)
            if (Set == null)
            {
                throw new InvalidDataException("Set is a required property for SettingModel and cannot be null");
            }
            else
            {
                this.Set = Set;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for SettingModel and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Value = Value;
        }
        
        /// <summary>
        /// The unique ID number of this setting.
        /// </summary>
        /// <value>The unique ID number of this setting.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// The unique ID number of the company this setting refers to.
        /// </summary>
        /// <value>The unique ID number of the company this setting refers to.</value>
        [DataMember(Name="companyId", EmitDefaultValue=false)]
        public int? CompanyId { get; private set; }
        /// <summary>
        /// A user-defined \&quot;set\&quot; containing this name-value pair.
        /// </summary>
        /// <value>A user-defined \&quot;set\&quot; containing this name-value pair.</value>
        [DataMember(Name="set", EmitDefaultValue=false)]
        public string Set { get; set; }
        /// <summary>
        /// A user-defined \&quot;name\&quot; for this name-value pair.
        /// </summary>
        /// <value>A user-defined \&quot;name\&quot; for this name-value pair.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The value of this name-value pair.
        /// </summary>
        /// <value>The value of this name-value pair.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Set: ").Append(Set).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as SettingModel);
        }

        /// <summary>
        /// Returns true if SettingModel instances are equal
        /// </summary>
        /// <param name="other">Instance of SettingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CompanyId == other.CompanyId ||
                    this.CompanyId != null &&
                    this.CompanyId.Equals(other.CompanyId)
                ) && 
                (
                    this.Set == other.Set ||
                    this.Set != null &&
                    this.Set.Equals(other.Set)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.CompanyId != null)
                    hash = hash * 59 + this.CompanyId.GetHashCode();
                if (this.Set != null)
                    hash = hash * 59 + this.Set.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }
    }

}
