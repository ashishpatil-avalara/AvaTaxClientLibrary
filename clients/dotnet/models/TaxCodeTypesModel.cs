using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Information about Avalara-defined tax code types.
        ///             This list is used when creating tax codes and tax rules.
    /// </summary>
    public class TaxCodeTypesModel
    {
        /// <summary>
        /// The list of Avalara-defined tax code types.
        /// </summary>
        public Dictionary<string, string> types { get; set; }



        /// <summary>
        /// Convert this object to a JSON string of itself
        /// </summary>
        /// <returns>A JSON string of this object</returns>
        public override string ToString()
		{
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented });
		}
    }
}
