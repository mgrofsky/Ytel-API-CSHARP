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
    public class ViewTemplateInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid templateId;
        private string responseType = "json";

        /// <summary>
        /// The unique identifier for a template object
        /// </summary>
        [JsonProperty("TemplateId")]
        public Guid TemplateId 
        { 
            get 
            {
                return this.templateId; 
            } 
            set 
            {
                this.templateId = value;
                onPropertyChanged("TemplateId");
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