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
    public class UpdatePhoneNumberInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string phoneNumber;
        private string voiceUrl;
        private string responseType = "json";
        private string friendlyName;
        private Models.HttpActionEnum? voiceMethod;
        private string voiceFallbackUrl;
        private Models.HttpActionEnum? voiceFallbackMethod;
        private string hangupCallback;
        private Models.HttpActionEnum? hangupCallbackMethod;
        private string heartbeatUrl;
        private Models.HttpActionEnum? heartbeatMethod;
        private string smsUrl;
        private Models.HttpActionEnum? smsMethod;
        private string smsFallbackUrl;
        private Models.HttpActionEnum? smsFallbackMethod;

        /// <summary>
        /// A valid Ytel number (E.164 format).
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber 
        { 
            get 
            {
                return this.phoneNumber; 
            } 
            set 
            {
                this.phoneNumber = value;
                onPropertyChanged("PhoneNumber");
            }
        }

        /// <summary>
        /// URL requested once the call connects
        /// </summary>
        [JsonProperty("VoiceUrl")]
        public string VoiceUrl 
        { 
            get 
            {
                return this.voiceUrl; 
            } 
            set 
            {
                this.voiceUrl = value;
                onPropertyChanged("VoiceUrl");
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
        /// Phone number friendly name description
        /// </summary>
        [JsonProperty("FriendlyName")]
        public string FriendlyName 
        { 
            get 
            {
                return this.friendlyName; 
            } 
            set 
            {
                this.friendlyName = value;
                onPropertyChanged("FriendlyName");
            }
        }

        /// <summary>
        /// Post or Get
        /// </summary>
        [JsonProperty("VoiceMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? VoiceMethod 
        { 
            get 
            {
                return this.voiceMethod; 
            } 
            set 
            {
                this.voiceMethod = value;
                onPropertyChanged("VoiceMethod");
            }
        }

        /// <summary>
        /// URL requested if the voice URL is not available
        /// </summary>
        [JsonProperty("VoiceFallbackUrl")]
        public string VoiceFallbackUrl 
        { 
            get 
            {
                return this.voiceFallbackUrl; 
            } 
            set 
            {
                this.voiceFallbackUrl = value;
                onPropertyChanged("VoiceFallbackUrl");
            }
        }

        /// <summary>
        /// Post or Get
        /// </summary>
        [JsonProperty("VoiceFallbackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? VoiceFallbackMethod 
        { 
            get 
            {
                return this.voiceFallbackMethod; 
            } 
            set 
            {
                this.voiceFallbackMethod = value;
                onPropertyChanged("VoiceFallbackMethod");
            }
        }

        /// <summary>
        /// callback url after a hangup occurs
        /// </summary>
        [JsonProperty("HangupCallback")]
        public string HangupCallback 
        { 
            get 
            {
                return this.hangupCallback; 
            } 
            set 
            {
                this.hangupCallback = value;
                onPropertyChanged("HangupCallback");
            }
        }

        /// <summary>
        /// Post or Get
        /// </summary>
        [JsonProperty("HangupCallbackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? HangupCallbackMethod 
        { 
            get 
            {
                return this.hangupCallbackMethod; 
            } 
            set 
            {
                this.hangupCallbackMethod = value;
                onPropertyChanged("HangupCallbackMethod");
            }
        }

        /// <summary>
        /// URL requested once the call connects
        /// </summary>
        [JsonProperty("HeartbeatUrl")]
        public string HeartbeatUrl 
        { 
            get 
            {
                return this.heartbeatUrl; 
            } 
            set 
            {
                this.heartbeatUrl = value;
                onPropertyChanged("HeartbeatUrl");
            }
        }

        /// <summary>
        /// URL that can be requested every 60 seconds during the call to notify of elapsed time
        /// </summary>
        [JsonProperty("HeartbeatMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? HeartbeatMethod 
        { 
            get 
            {
                return this.heartbeatMethod; 
            } 
            set 
            {
                this.heartbeatMethod = value;
                onPropertyChanged("HeartbeatMethod");
            }
        }

        /// <summary>
        /// URL requested when an SMS is received
        /// </summary>
        [JsonProperty("SmsUrl")]
        public string SmsUrl 
        { 
            get 
            {
                return this.smsUrl; 
            } 
            set 
            {
                this.smsUrl = value;
                onPropertyChanged("SmsUrl");
            }
        }

        /// <summary>
        /// Post or Get
        /// </summary>
        [JsonProperty("SmsMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? SmsMethod 
        { 
            get 
            {
                return this.smsMethod; 
            } 
            set 
            {
                this.smsMethod = value;
                onPropertyChanged("SmsMethod");
            }
        }

        /// <summary>
        /// URL used if any errors occur during execution of InboundXML from an SMS or at initial request of the SmsUrl.
        /// </summary>
        [JsonProperty("SmsFallbackUrl")]
        public string SmsFallbackUrl 
        { 
            get 
            {
                return this.smsFallbackUrl; 
            } 
            set 
            {
                this.smsFallbackUrl = value;
                onPropertyChanged("SmsFallbackUrl");
            }
        }

        /// <summary>
        /// The HTTP method Ytel will use when URL requested if the SmsUrl is not available.
        /// </summary>
        [JsonProperty("SmsFallbackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? SmsFallbackMethod 
        { 
            get 
            {
                return this.smsFallbackMethod; 
            } 
            set 
            {
                this.smsFallbackMethod = value;
                onPropertyChanged("SmsFallbackMethod");
            }
        }
    }
} 