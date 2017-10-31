/*
 * Message360.Standard
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io )
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


namespace message360.Models
{
    public class ListUnsubscribesInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string responseType = "json";
        private string offset;
        private string limit;

        /// <summary>
        /// Response type format xml or json
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

        /// <summary>
        /// Starting record of the list
        /// </summary>
        [JsonProperty("offset")]
        public string Offset 
        { 
            get 
            {
                return this.offset; 
            } 
            set 
            {
                this.offset = value;
                onPropertyChanged("Offset");
            }
        }

        /// <summary>
        /// Maximum number of records to be returned
        /// </summary>
        [JsonProperty("limit")]
        public string Limit 
        { 
            get 
            {
                return this.limit; 
            } 
            set 
            {
                this.limit = value;
                onPropertyChanged("Limit");
            }
        }
    }
} 