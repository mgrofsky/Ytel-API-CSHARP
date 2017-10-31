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
    public class CreateConferenceInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string mfrom;
        private string to;
        private string url;
        private Models.HttpActionEnum method = Models.HttpActionEnum.POST;
        private string recordCallbackUrl;
        private string responseType = "json";
        private string statusCallBackUrl;
        private Models.HttpActionEnum? statusCallBackMethod;
        private string fallBackUrl;
        private Models.HttpActionEnum? fallBackMethod;
        private bool? record;
        private Models.HttpActionEnum? recordCallbackMethod;
        private string schdeuleTime;
        private int? timeout;

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
        public Models.HttpActionEnum Method 
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
        /// Recording parameters will be sent here upon completion.
        /// </summary>
        [JsonProperty("RecordCallbackUrl")]
        public string RecordCallbackUrl 
        { 
            get 
            {
                return this.recordCallbackUrl; 
            } 
            set 
            {
                this.recordCallbackUrl = value;
                onPropertyChanged("RecordCallbackUrl");
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
        /// URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the conference is finished.
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
        public Models.HttpActionEnum? StatusCallBackMethod 
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
        public Models.HttpActionEnum? FallBackMethod 
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
        /// Specifies if the conference should be recorded.
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
        /// Specifies the HTTP method used to request the required URL once conference connects.
        /// </summary>
        [JsonProperty("RecordCallbackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? RecordCallbackMethod 
        { 
            get 
            {
                return this.recordCallbackMethod; 
            } 
            set 
            {
                this.recordCallbackMethod = value;
                onPropertyChanged("RecordCallbackMethod");
            }
        }

        /// <summary>
        /// Schedule conference in future. Schedule time must be greater than current time
        /// </summary>
        [JsonProperty("SchdeuleTime")]
        public string SchdeuleTime 
        { 
            get 
            {
                return this.schdeuleTime; 
            } 
            set 
            {
                this.schdeuleTime = value;
                onPropertyChanged("SchdeuleTime");
            }
        }

        /// <summary>
        /// The number of seconds the call stays on the line while waiting for an answer. The max time limit is 999 and the default limit is 60 seconds but lower times can be set.
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
    }
} 