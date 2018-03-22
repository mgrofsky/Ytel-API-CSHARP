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
    public class SendSMSInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string mfrom;
        private string to;
        private string body;
        private string responseType = "json";
        private Models.HttpActionEnum? method;
        private string messageStatusCallback;
        private bool? smartsms = false;
        private bool? deliveryStatus = false;

        /// <summary>
        /// The 10-digit SMS-enabled Ytel number (E.164 format) in which the message is sent.
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
        /// The 10-digit phone number (E.164 format) that will receive the message.
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
        /// The body message that is to be sent in the text.
        /// </summary>
        [JsonProperty("Body")]
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
        /// URL that can be requested to receive notification when SMS has Sent. A set of default parameters will be sent here once the SMS is finished.
        /// </summary>
        [JsonProperty("MessageStatusCallback")]
        public string MessageStatusCallback 
        { 
            get 
            {
                return this.messageStatusCallback; 
            } 
            set 
            {
                this.messageStatusCallback = value;
                onPropertyChanged("MessageStatusCallback");
            }
        }

        /// <summary>
        /// Check's 'to' number can receive sms or not using Carrier API, if wireless = true then text sms is sent, else wireless = false then call is recieved to end user with audible message.
        /// </summary>
        [JsonProperty("Smartsms")]
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

        /// <summary>
        /// Delivery reports are a method to tell your system if the message has arrived on the destination phone.
        /// </summary>
        [JsonProperty("DeliveryStatus")]
        public bool? DeliveryStatus 
        { 
            get 
            {
                return this.deliveryStatus; 
            } 
            set 
            {
                this.deliveryStatus = value;
                onPropertyChanged("DeliveryStatus");
            }
        }
    }
} 