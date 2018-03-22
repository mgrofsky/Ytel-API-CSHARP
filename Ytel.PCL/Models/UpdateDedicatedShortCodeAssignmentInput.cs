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
    public class UpdateDedicatedShortCodeAssignmentInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string shortcode;
        private string responseType = "json";
        private string friendlyName;
        private string callbackMethod;
        private string callbackUrl;
        private string fallbackMethod;
        private string fallbackUrl;

        /// <summary>
        /// List of valid dedicated shortcode to your Ytel account.
        /// </summary>
        [JsonProperty("Shortcode")]
        public string Shortcode 
        { 
            get 
            {
                return this.shortcode; 
            } 
            set 
            {
                this.shortcode = value;
                onPropertyChanged("Shortcode");
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
        /// User generated name of the dedicated shortcode.
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
        /// Specifies the HTTP method used to request the required StatusCallBackUrl once call connects.
        /// </summary>
        [JsonProperty("CallbackMethod")]
        public string CallbackMethod 
        { 
            get 
            {
                return this.callbackMethod; 
            } 
            set 
            {
                this.callbackMethod = value;
                onPropertyChanged("CallbackMethod");
            }
        }

        /// <summary>
        /// URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished.
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl 
        { 
            get 
            {
                return this.callbackUrl; 
            } 
            set 
            {
                this.callbackUrl = value;
                onPropertyChanged("CallbackUrl");
            }
        }

        /// <summary>
        /// Specifies the HTTP method used to request the required FallbackUrl once call connects.
        /// </summary>
        [JsonProperty("FallbackMethod")]
        public string FallbackMethod 
        { 
            get 
            {
                return this.fallbackMethod; 
            } 
            set 
            {
                this.fallbackMethod = value;
                onPropertyChanged("FallbackMethod");
            }
        }

        /// <summary>
        /// URL used if any errors occur during execution of InboundXML or at initial request of the required Url provided with the POST.
        /// </summary>
        [JsonProperty("FallbackUrl")]
        public string FallbackUrl 
        { 
            get 
            {
                return this.fallbackUrl; 
            } 
            set 
            {
                this.fallbackUrl = value;
                onPropertyChanged("FallbackUrl");
            }
        }
    }
} 