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
    public class BulkBuyNumberInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.NumberTypeEnum numberType;
        private string areaCode;
        private string quantity;
        private string responseType = "json";
        private string leftover;

        /// <summary>
        /// The capability the number supports.
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
        /// Specifies the area code for the returned list of available numbers. Only available for North American numbers.
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
        /// A positive integer that tells how many number you want to buy at a time.
        /// </summary>
        [JsonProperty("Quantity")]
        public string Quantity 
        { 
            get 
            {
                return this.quantity; 
            } 
            set 
            {
                this.quantity = value;
                onPropertyChanged("Quantity");
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
        /// If desired quantity is unavailable purchase what is available .
        /// </summary>
        [JsonProperty("Leftover")]
        public string Leftover 
        { 
            get 
            {
                return this.leftover; 
            } 
            set 
            {
                this.leftover = value;
                onPropertyChanged("Leftover");
            }
        }
    }
} 