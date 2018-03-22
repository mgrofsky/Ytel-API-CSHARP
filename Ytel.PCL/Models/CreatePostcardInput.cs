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
    public class CreatePostcardInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string to;
        private string mfrom;
        private string attachbyid;
        private string front;
        private string back;
        private string message;
        private string setting;
        private string responseType = "json";
        private string description;
        private string htmldata;

        /// <summary>
        /// The AddressId or an object structured when creating an address by addresses/Create.
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
        /// The AddressId or an object structured when creating an address by addresses/Create.
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
        /// Set an existing postcard by attaching its PostcardId.
        /// </summary>
        [JsonProperty("attachbyid")]
        public string Attachbyid 
        { 
            get 
            {
                return this.attachbyid; 
            } 
            set 
            {
                this.attachbyid = value;
                onPropertyChanged("Attachbyid");
            }
        }

        /// <summary>
        /// A 4.25"x6.25" or 6.25"x11.25" image to use as the front of the postcard.  This can be a URL, local file, or an HTML string. Supported file types are PDF, PNG, and JPEG.
        /// </summary>
        [JsonProperty("front")]
        public string Front 
        { 
            get 
            {
                return this.front; 
            } 
            set 
            {
                this.front = value;
                onPropertyChanged("Front");
            }
        }

        /// <summary>
        /// A 4.25"x6.25" or 6.25"x11.25" image to use as the back of the postcard, supplied as a URL, local file, or HTML string.  This allows you to customize your back design, but we will still insert the recipient address for you.
        /// </summary>
        [JsonProperty("back")]
        public string Back 
        { 
            get 
            {
                return this.back; 
            } 
            set 
            {
                this.back = value;
                onPropertyChanged("Back");
            }
        }

        /// <summary>
        /// The message for the back of the postcard with a maximum of 350 characters.
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }

        /// <summary>
        /// Code for the dimensions of the media to be printed.
        /// </summary>
        [JsonProperty("setting")]
        public string Setting 
        { 
            get 
            {
                return this.setting; 
            } 
            set 
            {
                this.setting = value;
                onPropertyChanged("Setting");
            }
        }

        /// <summary>
        /// Response Type either json or xml
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
        /// A description for the postcard.
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// A string value that contains HTML markup.
        /// </summary>
        [JsonProperty("htmldata")]
        public string Htmldata 
        { 
            get 
            {
                return this.htmldata; 
            } 
            set 
            {
                this.htmldata = value;
                onPropertyChanged("Htmldata");
            }
        }
    }
} 