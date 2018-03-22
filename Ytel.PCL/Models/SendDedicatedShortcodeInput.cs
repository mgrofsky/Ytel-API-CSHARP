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
    public class SendDedicatedShortcodeInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int shortcode;
        private double to;
        private string body;
        private string responseType = "json";
        private Models.HttpActionEnum? method;
        private string messagestatuscallback;

        /// <summary>
        /// Your dedicated shortcode
        /// </summary>
        [JsonProperty("shortcode")]
        public int Shortcode 
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
        /// The number to send your SMS to
        /// </summary>
        [JsonProperty("to")]
        public double To 
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
        /// The body of your message
        /// </summary>
        [JsonProperty("body")]
        public string Body 
        { 
            get 
            {
                return this.body; 
            } 
            set 
            {
                this.body = value;
                onPropertyChanged("Body");
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
        /// Specifies the HTTP method used to request the required URL once the Short Code message is sent.GET or POST
        /// </summary>
        [JsonProperty("method", ItemConverterType = typeof(StringValuedEnumConverter))]
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
        /// URL that can be requested to receive notification when Short Code message was sent.
        /// </summary>
        [JsonProperty("messagestatuscallback")]
        public string Messagestatuscallback 
        { 
            get 
            {
                return this.messagestatuscallback; 
            } 
            set 
            {
                this.messagestatuscallback = value;
                onPropertyChanged("Messagestatuscallback");
            }
        }
    }
} 