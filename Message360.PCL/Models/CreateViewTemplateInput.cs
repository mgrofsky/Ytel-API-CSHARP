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
    public class CreateViewTemplateInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid templateid;
        private string responseType = "json";

        /// <summary>
        /// The unique identifier for a template object
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