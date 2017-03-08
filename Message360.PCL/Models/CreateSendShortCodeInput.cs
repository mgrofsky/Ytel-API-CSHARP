/*
 * Message360.PCL
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
using message360;
using message360.Utilities;

namespace message360.Models
{
    public class CreateSendShortCodeInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string shortcode;
        private string tocountrycode = "1";
        private string to;
        private Guid templateid;
        private string method = "GET";
        private string messageStatusCallback;
        private string responseType = "json";

        /// <summary>
        /// The Short Code number that is the sender of this message
        /// </summary>
        [JsonProperty("shortcode")]
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
        /// The country code for sending this message
        /// </summary>
        [JsonProperty("tocountrycode")]
        public string Tocountrycode 
        { 
            get 
            {
                return this.tocountrycode; 
            } 
            set 
            {
                this.tocountrycode = value;
                onPropertyChanged("Tocountrycode");
            }
        }

        /// <summary>
        /// A valid 10-digit number that should receive the message+
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
        /// The unique identifier for the template used for the message
        /// </summary>
        [JsonProperty("templateid")]
        public Guid Templateid 
        { 
            get 
            {
                return this.templateid; 
            } 
            set 
            {
                this.templateid = value;
                onPropertyChanged("Templateid");
            }
        }

        /// <summary>
        /// Specifies the HTTP method used to request the required URL once the Short Code message is sent.
        /// </summary>
        [JsonProperty("Method")]
        public string Method 
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
    }
} 