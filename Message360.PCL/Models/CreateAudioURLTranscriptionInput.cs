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
    public class CreateAudioURLTranscriptionInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string audioUrl;
        private string responseType = "json";

        /// <summary>
        /// Audio url
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl 
        { 
            get 
            {
                return this.audioUrl; 
            } 
            set 
            {
                this.audioUrl = value;
                onPropertyChanged("AudioUrl");
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