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
    public class RecordingTranscriptionInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string recordingSid;
        private string responseType = "json";

        /// <summary>
        /// Unique Recording sid
        /// </summary>
        [JsonProperty("RecordingSid")]
        public string RecordingSid 
        { 
            get 
            {
                return this.recordingSid; 
            } 
            set 
            {
                this.recordingSid = value;
                onPropertyChanged("RecordingSid");
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