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
    public class GetDIDScoreNumberInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string phonenumber;
        private string responseType = "json";

        /// <summary>
        /// Specifies the multiple phone numbers for check updated spamscore .
        /// </summary>
        [JsonProperty("Phonenumber")]
        public string Phonenumber 
        { 
            get 
            {
                return this.phonenumber; 
            } 
            set 
            {
                this.phonenumber = value;
                onPropertyChanged("Phonenumber");
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