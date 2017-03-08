/*
 * Message360.PCL
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
using message360;
using message360.Utilities;

namespace message360.Models
{
    public class CreateListInvalidInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string responseType = "json";
        private string offet;
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
        /// Starting record for listing out emails
        /// </summary>
        [JsonProperty("offet")]
        public string Offet 
        { 
            get 
            {
                return this.offet; 
            } 
            set 
            {
                this.offet = value;
                onPropertyChanged("Offet");
            }
        }

        /// <summary>
        /// Maximum number of records to return
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