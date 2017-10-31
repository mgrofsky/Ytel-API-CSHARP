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
    public class UpdateAssignmentInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string shortcode;
        private string responseType = "json";
        private string friendlyName;
        private string callbackUrl;
        private Models.HttpActionEnum? callbackMethod;
        private string fallbackUrl;
        private Models.HttpActionEnum? fallbackUrlMethod;

        /// <summary>
        /// List of valid shortcode to your message360 account
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
        /// User generated name of the shortcode
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
        /// Specifies the HTTP method used to request the required StatusCallBackUrl once call connects.
        /// </summary>
        [JsonProperty("CallbackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? CallbackMethod 
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

        /// <summary>
        /// Specifies the HTTP method used to request the required FallbackUrl once call connects.
        /// </summary>
        [JsonProperty("FallbackUrlMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? FallbackUrlMethod 
        { 
            get 
            {
                return this.fallbackUrlMethod; 
            } 
            set 
            {
                this.fallbackUrlMethod = value;
                onPropertyChanged("FallbackUrlMethod");
            }
        }
    }
} 