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
    public class ViewShortcodeInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string messageSid;
        private string responseType = "json";

        /// <summary>
        /// The unique identifier for the sms resource
        /// </summary>
        [JsonProperty("MessageSid")]
        public string MessageSid 
        { 
            get 
            {
                return this.messageSid; 
            } 
            set 
            {
                this.messageSid = value;
                onPropertyChanged("MessageSid");
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