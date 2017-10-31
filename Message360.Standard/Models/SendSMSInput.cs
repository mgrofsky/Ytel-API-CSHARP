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
    public class SendSMSInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string mfrom;
        private string to;
        private string body;
        private string responseType = "json";
        private Models.HttpActionEnum? method;
        private string messagestatuscallback;
        private bool? smartsms = false;

        /// <summary>
        /// SMS enabled Message360 number to send this message from
        /// </summary>
        [JsonProperty("from")]
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
        /// Number to send the SMS to
        /// </summary>
        [JsonProperty("to")]
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
        /// Text Message To Send
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
        /// Specifies the HTTP method used to request the required URL once SMS sent.
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
        /// URL that can be requested to receive notification when SMS has Sent. A set of default parameters will be sent here once the SMS is finished.
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

        /// <summary>
        /// Check's 'to' number can receive sms or not using Carrier API, if wireless = true then text sms is sent, else wireless = false then call is recieved to end user with audible message.
        /// </summary>
        [JsonProperty("smartsms")]
        public bool? Smartsms 
        { 
            get 
            {
                return this.smartsms; 
            } 
            set 
            {
                this.smartsms = value;
                onPropertyChanged("Smartsms");
            }
        }
    }
} 