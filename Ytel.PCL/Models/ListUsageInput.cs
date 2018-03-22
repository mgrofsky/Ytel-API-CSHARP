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
    public class ListUsageInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string responseType = "json";
        private Models.ProductCodeEnum? productCode = Models.ProductCodeEnum.ALL;
        private string startDate = "2016-09-06";
        private string endDate = "2016-09-06";
        private string includeSubAccounts;

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
        /// Filter usage results by product type.
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
        /// Filter usage objects by start date.
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
        /// Filter usage objects by end date.
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

        /// <summary>
        /// Will include all subaccount usage data
        /// </summary>
        [JsonProperty("IncludeSubAccounts")]
        public string IncludeSubAccounts 
        { 
            get 
            {
                return this.includeSubAccounts; 
            } 
            set 
            {
                this.includeSubAccounts = value;
                onPropertyChanged("IncludeSubAccounts");
            }
        }
    }
} 