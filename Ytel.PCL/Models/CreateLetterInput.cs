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
    public class CreateLetterInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string to;
        private string mfrom;
        private string attachbyid;
        private string file;
        private string color;
        private string responseType = "json";
        private string description;
        private string extraservice;
        private string doublesided;
        private string template;
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
        /// Set an existing letter by attaching its LetterId.
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
        /// File can be a 8.5"x11" PDF uploaded file or URL that links to a file.
        /// </summary>
        [JsonProperty("file")]
        public string File 
        { 
            get 
            {
                return this.file; 
            } 
            set 
            {
                this.file = value;
                onPropertyChanged("File");
            }
        }

        /// <summary>
        /// Specify if letter should be printed in color.
        /// </summary>
        [JsonProperty("color")]
        public string Color 
        { 
            get 
            {
                return this.color; 
            } 
            set 
            {
                this.color = value;
                onPropertyChanged("Color");
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
        /// A description for the letter.
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
        /// Add an extra service to your letter. Options are "certified" or "registered". Certified provides tracking and delivery confirmation for domestic destinations and is an additional $5.00. Registered provides tracking and confirmation for international addresses and is an additional $16.50.
        /// </summary>
        [JsonProperty("extraservice")]
        public string Extraservice 
        { 
            get 
            {
                return this.extraservice; 
            } 
            set 
            {
                this.extraservice = value;
                onPropertyChanged("Extraservice");
            }
        }

        /// <summary>
        /// Specify if letter should be printed on both sides.
        /// </summary>
        [JsonProperty("doublesided")]
        public string Doublesided 
        { 
            get 
            {
                return this.doublesided; 
            } 
            set 
            {
                this.doublesided = value;
                onPropertyChanged("Doublesided");
            }
        }

        /// <summary>
        /// Boolean that defaults to true. When set to false, this specifies that your letter does not follow the m360 address template. In this case, a blank address page will be inserted at the beginning of your file and you will be charged for the extra page.
        /// </summary>
        [JsonProperty("template")]
        public string Template 
        { 
            get 
            {
                return this.template; 
            } 
            set 
            {
                this.template = value;
                onPropertyChanged("Template");
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