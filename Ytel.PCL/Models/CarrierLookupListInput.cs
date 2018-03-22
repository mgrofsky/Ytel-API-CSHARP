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
    public class CarrierLookupListInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string responseType = "json";
        private int? page = 1;
        private int? pageSize = 10;

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
        /// The page count to retrieve from the total results in the collection. Page indexing starts at 1.
        /// </summary>
        [JsonProperty("Page")]
        public int? Page 
        { 
            get 
            {
                return this.page; 
            } 
            set 
            {
                this.page = value;
                onPropertyChanged("Page");
            }
        }

        /// <summary>
        /// The count of objects to return per page.
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