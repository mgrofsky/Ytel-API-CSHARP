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
    public class ViewKeywordInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string keywordid;
        private string responseType = "json";

        /// <summary>
        /// The unique identifier of each keyword
        /// </summary>
        [JsonProperty("Keywordid")]
        public string Keywordid 
        { 
            get 
            {
                return this.keywordid; 
            } 
            set 
            {
                this.keywordid = value;
                onPropertyChanged("Keywordid");
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