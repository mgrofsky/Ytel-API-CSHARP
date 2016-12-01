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
    public class CreateGroupCallInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string fromCountryCode = "1";
        private string mfrom;
        private string toCountryCode = "1";
        private string to;
        private string url;
        private HttpAction? method;
        private string statusCallBackUrl;
        private HttpAction? statusCallBackMethod;
        private string fallBackUrl;
        private HttpAction? fallBackMethod;
        private string heartBeatUrl;
        private HttpAction? heartBeatMethod;
        private int? timeout;
        private string playDtmf;
        private string hideCallerId;
        private bool? record;
        private string recordCallBackUrl;
        private HttpAction? recordCallBackMethod;
        private bool? transcribe;
        private string transcribeCallBackUrl;
        private string responseType = "json";

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("HeartBeatMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public HttpAction? HeartBeatMethod 
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("HideCallerId")]
        public string HideCallerId 
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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