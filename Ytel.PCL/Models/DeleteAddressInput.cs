/*
 * Ytel.PCL
 *
 * This file was automatically generated for ytel by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;


namespace ytel.Models
{
    public class DeleteAddressInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string addressid;
        private string responseType = "json";

        /// <summary>
        /// The identifier of the address to be deleted.
        /// </summary>
        [JsonProperty("addressid")]
        public string Addressid 
        { 
            get 
            {
                return this.addressid; 
            } 
            set 
            {
                this.addressid = value;
                onPropertyChanged("Addressid");
            }
        }

        /// <summary>
        /// Response type either json or xml
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType 
        { 
            get 
            {
                return this.responseType; 
            } 
            set 
            {
                this.responseType = value;
                onPropertyChanged("ResponseType");
            }
        }
    }
} 