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
    public class CreateSendRinglessVMInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string fromCountryCode;
        private string mfrom;
        private string toCountryCode;
        private string to;
        private string voiceMailURL;
        private string method = "GET";
        private string responseType = "json";
        private string statusCallBackUrl;
        private string statsCallBackMethod;

        /// <summary>
        /// From country code
        /// </summary>
        [JsonProperty("FromCountryCode")]
        public string FromCountryCode 
        { 
            get 
            {
                return this.fromCountryCode; 
            } 
            set 
            {
                this.fromCountryCode = value;
                onPropertyChanged("FromCountryCode");
            }
        }

        /// <summary>
        /// This number to display on Caller ID as calling
        /// </summary>
        [JsonProperty("From")]
        public string From 
        { 
            get 
            {
                return this.mfrom; 
            } 
            set 
            {
                this.mfrom = value;
                onPropertyChanged("From");
            }
        }

        /// <summary>
        /// To country code
        /// </summary>
        [JsonProperty("ToCountryCode")]
        public string ToCountryCode 
        { 
            get 
            {
                return this.toCountryCode; 
            } 
            set 
            {
                this.toCountryCode = value;
                onPropertyChanged("ToCountryCode");
            }
        }

        /// <summary>
        /// To number
        /// </summary>
        [JsonProperty("To")]
        public string To 
        { 
            get 
            {
                return this.to; 
            } 
            set 
            {
                this.to = value;
                onPropertyChanged("To");
            }
        }

        /// <summary>
        /// URL to an audio file
        /// </summary>
        [JsonProperty("VoiceMailURL")]
        public string VoiceMailURL 
        { 
            get 
            {
                return this.voiceMailURL; 
            } 
            set 
            {
                this.voiceMailURL = value;
                onPropertyChanged("VoiceMailURL");
            }
        }

        /// <summary>
        /// Not currently used in this version
        /// </summary>
        [JsonProperty("Method")]
        public string Method 
        { 
            get 
            {
                return this.method; 
            } 
            set 
            {
                this.method = value;
                onPropertyChanged("Method");
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

        /// <summary>
        /// URL to post the status of the Ringless request
        /// </summary>
        [JsonProperty("StatusCallBackUrl")]
        public string StatusCallBackUrl 
        { 
            get 
            {
                return this.statusCallBackUrl; 
            } 
            set 
            {
                this.statusCallBackUrl = value;
                onPropertyChanged("StatusCallBackUrl");
            }
        }

        /// <summary>
        /// POST or GET
        /// </summary>
        [JsonProperty("StatsCallBackMethod")]
        public string StatsCallBackMethod 
        { 
            get 
            {
                return this.statsCallBackMethod; 
            } 
            set 
            {
                this.statsCallBackMethod = value;
                onPropertyChanged("StatsCallBackMethod");
            }
        }
    }
} 