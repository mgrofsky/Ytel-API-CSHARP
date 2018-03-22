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
    public class AudioURLTranscriptionInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string audiourl;
        private string responseType = "json";

        /// <summary>
        /// URL pointing to the location of the audio file that is to be transcribed.
        /// </summary>
        [JsonProperty("audiourl")]
        public string Audiourl 
        { 
            get 
            {
                return this.audiourl; 
            } 
            set 
            {
                this.audiourl = value;
                onPropertyChanged("Audiourl");
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