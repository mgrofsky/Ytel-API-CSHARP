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
    public class ViewConferenceInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string conferenceSid;
        private string responseType = "json";

        /// <summary>
        /// The unique identifier of each conference resource
        /// </summary>
        [JsonProperty("ConferenceSid")]
        public string ConferenceSid 
        { 
            get 
            {
                return this.conferenceSid; 
            } 
            set 
            {
                this.conferenceSid = value;
                onPropertyChanged("ConferenceSid");
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