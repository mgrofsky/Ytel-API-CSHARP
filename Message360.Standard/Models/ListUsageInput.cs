/*
 * Message360.Standard
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
    public class ListUsageInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string responseType = "json";
        private Models.ProductCodeEnum? productCode = Models.ProductCodeEnum.ALL;
        private string startDate = "2016-09-06";
        private string endDate = "2016-09-06";

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
        /// Product Code
        /// </summary>
        [JsonProperty("ProductCode")]
        public Models.ProductCodeEnum? ProductCode 
        { 
            get 
            {
                return this.productCode; 
            } 
            set 
            {
                this.productCode = value;
                onPropertyChanged("ProductCode");
            }
        }

        /// <summary>
        /// Start Usage Date
        /// </summary>
        [JsonProperty("startDate")]
        public string StartDate 
        { 
            get 
            {
                return this.startDate; 
            } 
            set 
            {
                this.startDate = value;
                onPropertyChanged("StartDate");
            }
        }

        /// <summary>
        /// End Usage Date
        /// </summary>
        [JsonProperty("endDate")]
        public string EndDate 
        { 
            get 
            {
                return this.endDate; 
            } 
            set 
            {
                this.endDate = value;
                onPropertyChanged("EndDate");
            }
        }
    }
} 