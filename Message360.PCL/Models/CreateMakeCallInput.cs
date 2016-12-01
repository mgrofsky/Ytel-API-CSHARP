/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 12/01/2016
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
using message360.Utilities;

namespace message360.Models
{
    public class CreateMakeCallInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string fromCountryCode;
        private string mfrom;
        private string toCountryCode;
        private string to;
        private string url;
        private HttpAction? method;
        private string statusCallBackUrl;
        private HttpAction? statusCallBackMethod;
        private string fallBackUrl;
        private HttpAction? fallBackMethod;
        private string heartBeatUrl;
        private bool? heartBeatMethod;
        private int? timeout;
        private string playDtmf;
        private bool? hideCallerId;
        private bool? record;
        private string recordCallBackUrl;
        private HttpAction? recordCallBackMethod;
        private bool? transcribe;
        private string transcribeCallBackUrl;
        private IfMachine? ifMachine;
        private string responseType = "json";

        /// <summary>
        /// from country code
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
        /// To cuntry code number
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
        /// URL requested once the call connects
        /// </summary>
        [JsonProperty("Url")]
        public string Url 
        { 
            get 
            {
                return this.url; 
            } 
            set 
            {
                this.url = value;
                onPropertyChanged("Url");
            }
        }

        /// <summary>
        /// Specifies the HTTP method used to request the required URL once call connects.
        /// </summary>
        [JsonProperty("Method", ItemConverterType = typeof(StringValuedEnumConverter))]
        public HttpAction? Method 
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
        /// specifies the HTTP methodlinkclass used to request StatusCallbackUrl.
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
        /// Specifies the HTTP methodlinkclass used to request StatusCallbackUrl.
        /// </summary>
        [JsonProperty("StatusCallBackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public HttpAction? StatusCallBackMethod 
        { 
            get 
            {
                return this.statusCallBackMethod; 
            } 
            set 
            {
                this.statusCallBackMethod = value;
                onPropertyChanged("StatusCallBackMethod");
            }
        }

        /// <summary>
        /// URL requested if the initial Url parameter fails or encounters an error
        /// </summary>
        [JsonProperty("FallBackUrl")]
        public string FallBackUrl 
        { 
            get 
            {
                return this.fallBackUrl; 
            } 
            set 
            {
                this.fallBackUrl = value;
                onPropertyChanged("FallBackUrl");
            }
        }

        /// <summary>
        /// Specifies the HTTP method used to request the required FallbackUrl once call connects.
        /// </summary>
        [JsonProperty("FallBackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public HttpAction? FallBackMethod 
        { 
            get 
            {
                return this.fallBackMethod; 
            } 
            set 
            {
                this.fallBackMethod = value;
                onPropertyChanged("FallBackMethod");
            }
        }

        /// <summary>
        /// URL that can be requested every 60 seconds during the call to notify of elapsed tim
        /// </summary>
        [JsonProperty("HeartBeatUrl")]
        public string HeartBeatUrl 
        { 
            get 
            {
                return this.heartBeatUrl; 
            } 
            set 
            {
                this.heartBeatUrl = value;
                onPropertyChanged("HeartBeatUrl");
            }
        }

        /// <summary>
        /// Specifies the HTTP method used to request HeartbeatUrl.
        /// </summary>
        [JsonProperty("HeartBeatMethod")]
        public bool? HeartBeatMethod 
        { 
            get 
            {
                return this.heartBeatMethod; 
            } 
            set 
            {
                this.heartBeatMethod = value;
                onPropertyChanged("HeartBeatMethod");
            }
        }

        /// <summary>
        /// Time (in seconds) Message360 should wait while the call is ringing before canceling the call
        /// </summary>
        [JsonProperty("Timeout")]
        public int? Timeout 
        { 
            get 
            {
                return this.timeout; 
            } 
            set 
            {
                this.timeout = value;
                onPropertyChanged("Timeout");
            }
        }

        /// <summary>
        /// DTMF Digits to play to the call once it connects. 0-9, #, or *
        /// </summary>
        [JsonProperty("PlayDtmf")]
        public string PlayDtmf 
        { 
            get 
            {
                return this.playDtmf; 
            } 
            set 
            {
                this.playDtmf = value;
                onPropertyChanged("PlayDtmf");
            }
        }

        /// <summary>
        /// Specifies if the caller id will be hidden
        /// </summary>
        [JsonProperty("HideCallerId")]
        public bool? HideCallerId 
        { 
            get 
            {
                return this.hideCallerId; 
            } 
            set 
            {
                this.hideCallerId = value;
                onPropertyChanged("HideCallerId");
            }
        }

        /// <summary>
        /// Specifies if the call should be recorded
        /// </summary>
        [JsonProperty("Record")]
        public bool? Record 
        { 
            get 
            {
                return this.record; 
            } 
            set 
            {
                this.record = value;
                onPropertyChanged("Record");
            }
        }

        /// <summary>
        /// Recording parameters will be sent here upon completion
        /// </summary>
        [JsonProperty("RecordCallBackUrl")]
        public string RecordCallBackUrl 
        { 
            get 
            {
                return this.recordCallBackUrl; 
            } 
            set 
            {
                this.recordCallBackUrl = value;
                onPropertyChanged("RecordCallBackUrl");
            }
        }

        /// <summary>
        /// Method used to request the RecordCallback URL.
        /// </summary>
        [JsonProperty("RecordCallBackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public HttpAction? RecordCallBackMethod 
        { 
            get 
            {
                return this.recordCallBackMethod; 
            } 
            set 
            {
                this.recordCallBackMethod = value;
                onPropertyChanged("RecordCallBackMethod");
            }
        }

        /// <summary>
        /// Specifies if the call recording should be transcribed
        /// </summary>
        [JsonProperty("Transcribe")]
        public bool? Transcribe 
        { 
            get 
            {
                return this.transcribe; 
            } 
            set 
            {
                this.transcribe = value;
                onPropertyChanged("Transcribe");
            }
        }

        /// <summary>
        /// Transcription parameters will be sent here upon completion
        /// </summary>
        [JsonProperty("TranscribeCallBackUrl")]
        public string TranscribeCallBackUrl 
        { 
            get 
            {
                return this.transcribeCallBackUrl; 
            } 
            set 
            {
                this.transcribeCallBackUrl = value;
                onPropertyChanged("TranscribeCallBackUrl");
            }
        }

        /// <summary>
        /// How Message360 should handle the receiving numbers voicemail machine
        /// </summary>
        [JsonProperty("IfMachine", ItemConverterType = typeof(StringValuedEnumConverter))]
        public IfMachine? IfMachine 
        { 
            get 
            {
                return this.ifMachine; 
            } 
            set 
            {
                this.ifMachine = value;
                onPropertyChanged("IfMachine");
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