/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 11/28/2016
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
using message360;

namespace message360.Models
{
    public class UpdatePhoneNumberInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string phoneNumber;
        private string friendlyName;
        private string voiceUrl;
        private HttpAction? voiceMethod;
        private string voiceFallbackUrl;
        private HttpAction? voiceFallbackMethod;
        private string hangupCallback;
        private HttpAction? hangupCallbackMethod;
        private string heartbeatUrl;
        private HttpAction? heartbeatMethod;
        private string smsUrl;
        private HttpAction? smsMethod;
        private string smsFallbackUrl;
        private HttpAction? smsFallbackMethod;
        private string responseType = "json";

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("VoiceMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public HttpAction? VoiceMethod 
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("VoiceFallbackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public HttpAction? VoiceFallbackMethod 
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("HangupCallbackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public HttpAction? HangupCallbackMethod 
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
        public HttpAction? HeartbeatMethod 
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SmsMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public HttpAction? SmsMethod 
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
        /// URL requested once the call connects
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
        /// URL requested if the sms URL is not available
        /// </summary>
        [JsonProperty("SmsFallbackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public HttpAction? SmsFallbackMethod 
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
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 