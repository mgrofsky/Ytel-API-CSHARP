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
    public class SendRinglessVMInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string mfrom;
        private string rVMCallerId;
        private string to;
        private string voiceMailURL;
        private string responseType = "json";
        private Models.HttpActionEnum? method = Models.HttpActionEnum.GET;
        private string statusCallBackUrl;
        private Models.HttpActionEnum? statsCallBackMethod;

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
        /// Alternate caller ID required for RVM
        /// </summary>
        [JsonProperty("RVMCallerId")]
        public string RVMCallerId 
        { 
            get 
            {
                return this.rVMCallerId; 
            } 
            set 
            {
                this.rVMCallerId = value;
                onPropertyChanged("RVMCallerId");
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
        /// Not currently used in this version
        /// </summary>
        [JsonProperty("Method", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? Method 
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
        [JsonProperty("StatsCallBackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? StatsCallBackMethod 
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