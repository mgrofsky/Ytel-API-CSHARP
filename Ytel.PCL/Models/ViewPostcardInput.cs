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
    public class ViewPostcardInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string postcardid;
        private string responseType = "json";

        /// <summary>
        /// The unique identifier for a postcard object.
        /// </summary>
        [JsonProperty("postcardid")]
        public string Postcardid 
        { 
            get 
            {
                return this.postcardid; 
            } 
            set 
            {
                this.postcardid = value;
                onPropertyChanged("Postcardid");
            }
        }

        /// <summary>
        /// Response Type either json or xml
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