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
    /// Represents an item in your company&#39;s product catalog.
    /// </summary>
    [DataContract]
    public partial class ItemModel :  IEquatable<ItemModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemModel" /> class.
        /// </summary>
        /// <param name="ItemCode">A unique code representing this item. (required).</param>
        /// <param name="TaxCodeId">The unique ID number of the tax code that is applied when selling this item.              When creating or updating an item, you can either specify the Tax Code ID number or the Tax Code string; you do not need to specify both values..</param>
        /// <param name="TaxCode">The unique code string of the Tax Code that is applied when selling this item.              When creating or updating an item, you can either specify the Tax Code ID number or the Tax Code string; you do not need to specify both values..</param>
        /// <param name="Description">A friendly description of this item in your product catalog. (required).</param>
        public ItemModel(string ItemCode = null, int? TaxCodeId = null, string TaxCode = null, string Description = null)
        {
            // to ensure "ItemCode" is required (not null)
            if (ItemCode == null)
            {
                throw new InvalidDataException("ItemCode is a required property for ItemModel and cannot be null");
            }
            else
            {
                this.ItemCode = ItemCode;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ItemModel and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            this.TaxCodeId = TaxCodeId;
            this.TaxCode = TaxCode;
        }
        
        /// <summary>
        /// The unique ID number of this item.
        /// </summary>
        /// <value>The unique ID number of this item.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }
        /// <summary>
        /// The unique ID number of the company that owns this item.
        /// </summary>
        /// <value>The unique ID number of the company that owns this item.</value>
        [DataMember(Name="companyId", EmitDefaultValue=false)]
        public int? CompanyId { get; private set; }
        /// <summary>
        /// A unique code representing this item.
        /// </summary>
        /// <value>A unique code representing this item.</value>
        [DataMember(Name="itemCode", EmitDefaultValue=false)]
        public string ItemCode { get; set; }
        /// <summary>
        /// The unique ID number of the tax code that is applied when selling this item.              When creating or updating an item, you can either specify the Tax Code ID number or the Tax Code string; you do not need to specify both values.
        /// </summary>
        /// <value>The unique ID number of the tax code that is applied when selling this item.              When creating or updating an item, you can either specify the Tax Code ID number or the Tax Code string; you do not need to specify both values.</value>
        [DataMember(Name="taxCodeId", EmitDefaultValue=false)]
        public int? TaxCodeId { get; set; }
        /// <summary>
        /// The unique code string of the Tax Code that is applied when selling this item.              When creating or updating an item, you can either specify the Tax Code ID number or the Tax Code string; you do not need to specify both values.
        /// </summary>
        /// <value>The unique code string of the Tax Code that is applied when selling this item.              When creating or updating an item, you can either specify the Tax Code ID number or the Tax Code string; you do not need to specify both values.</value>
        [DataMember(Name="taxCode", EmitDefaultValue=false)]
        public string TaxCode { get; set; }
        /// <summary>
        /// A friendly description of this item in your product catalog.
        /// </summary>
        /// <value>A friendly description of this item in your product catalog.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The date when this record was created.
        /// </summary>
        /// <value>The date when this record was created.</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; private set; }
        /// <summary>
        /// The User ID of the user who created this record.
        /// </summary>
        /// <value>The User ID of the user who created this record.</value>
        [DataMember(Name="createdUserId", EmitDefaultValue=false)]
        public int? CreatedUserId { get; private set; }
        /// <summary>
        /// The date/time when this record was last modified.
        /// </summary>
        /// <value>The date/time when this record was last modified.</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; private set; }
        /// <summary>
        /// The user ID of the user who last modified this record.
        /// </summary>
        /// <value>The user ID of the user who last modified this record.</value>
        [DataMember(Name="modifiedUserId", EmitDefaultValue=false)]
        public int? ModifiedUserId { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ItemCode: ").Append(ItemCode).Append("\n");
            sb.Append("  TaxCodeId: ").Append(TaxCodeId).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedUserId: ").Append(CreatedUserId).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedUserId: ").Append(ModifiedUserId).Append("\n");
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
            return this.Equals(obj as ItemModel);
        }

        /// <summary>
        /// Returns true if ItemModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemModel other)
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
                    this.ItemCode == other.ItemCode ||
                    this.ItemCode != null &&
                    this.ItemCode.Equals(other.ItemCode)
                ) && 
                (
                    this.TaxCodeId == other.TaxCodeId ||
                    this.TaxCodeId != null &&
                    this.TaxCodeId.Equals(other.TaxCodeId)
                ) && 
                (
                    this.TaxCode == other.TaxCode ||
                    this.TaxCode != null &&
                    this.TaxCode.Equals(other.TaxCode)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.CreatedUserId == other.CreatedUserId ||
                    this.CreatedUserId != null &&
                    this.CreatedUserId.Equals(other.CreatedUserId)
                ) && 
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) && 
                (
                    this.ModifiedUserId == other.ModifiedUserId ||
                    this.ModifiedUserId != null &&
                    this.ModifiedUserId.Equals(other.ModifiedUserId)
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
                if (this.ItemCode != null)
                    hash = hash * 59 + this.ItemCode.GetHashCode();
                if (this.TaxCodeId != null)
                    hash = hash * 59 + this.TaxCodeId.GetHashCode();
                if (this.TaxCode != null)
                    hash = hash * 59 + this.TaxCode.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.CreatedUserId != null)
                    hash = hash * 59 + this.CreatedUserId.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                if (this.ModifiedUserId != null)
                    hash = hash * 59 + this.ModifiedUserId.GetHashCode();
                return hash;
            }
        }
    }

}
