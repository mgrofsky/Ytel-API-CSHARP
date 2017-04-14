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
using APIMATIC.SDK.Common;


namespace message360.Models
{
    public class CreateViewShortCodeInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string messagesid;
        private string responseType = "json";

        /// <summary>
        /// Message sid
        /// </summary>
        [JsonProperty("messagesid")]
        public string Messagesid 
        { 
            get 
            {
                return this.messagesid; 
            } 
            set 
            {
                this.messagesid = value;
                onPropertyChanged("Messagesid");
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