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
    public class AvailablePhoneNumberInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.NumberTypeEnum numbertype;
        private string areacode;
        private string responseType = "json";
        private int? pagesize = 10;

        /// <summary>
        /// Number type either SMS,Voice or all
        /// </summary>
        [JsonProperty("numbertype", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.NumberTypeEnum Numbertype 
        { 
            get 
            {
                return this.numbertype; 
            } 
            set 
            {
                this.numbertype = value;
                onPropertyChanged("Numbertype");
            }
        }

        /// <summary>
        /// Specifies the area code for the returned list of available numbers. Only available for North American numbers.
        /// </summary>
        [JsonProperty("areacode")]
        public string Areacode 
        { 
            get 
            {
                return this.areacode; 
            } 
            set 
            {
                this.areacode = value;
                onPropertyChanged("Areacode");
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
        /// The count of objects to return.
        /// </summary>
        [JsonProperty("pagesize")]
        public int? Pagesize 
        { 
            get 
            {
                return this.pagesize; 
            } 
            set 
            {
                this.pagesize = value;
                onPropertyChanged("Pagesize");
            }
        }
    }
} 