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
using APIMATIC.SDK.Common;


namespace message360.Models
{
    public class CreateAvailablePhoneNumberInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.NumberTypeEnum numberType;
        private string areaCode;
        private string responseType = "json";
        private int? pageSize = 10;

        /// <summary>
        /// Number type either SMS,Voice or all
        /// </summary>
        [JsonProperty("NumberType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.NumberTypeEnum NumberType 
        { 
            get 
            {
                return this.numberType; 
            } 
            set 
            {
                this.numberType = value;
                onPropertyChanged("NumberType");
            }
        }

        /// <summary>
        /// Phone Number Area Code
        /// </summary>
        [JsonProperty("AreaCode")]
        public string AreaCode 
        { 
            get 
            {
                return this.areaCode; 
            } 
            set 
            {
                this.areaCode = value;
                onPropertyChanged("AreaCode");
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
        /// Page Size
        /// </summary>
        [JsonProperty("PageSize")]
        public int? PageSize 
        { 
            get 
            {
                return this.pageSize; 
            } 
            set 
            {
                this.pageSize = value;
                onPropertyChanged("PageSize");
            }
        }
    }
} 