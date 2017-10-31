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
    public class ViewAccountInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string date;
        private string responseType = "json";

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Date")]
        public string Date 
        { 
            get 
            {
                return this.date; 
            } 
            set 
            {
                this.date = value;
                onPropertyChanged("Date");
            }
        }

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
    }
} 