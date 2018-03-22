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
    public class ListOutboundSharedShortcodesInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string responseType = "json";
        private int? page = 1;
        private int? pagesize = 10;
        private string shortcode;
        private string to;
        private string datesent;

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
        [JsonProperty("page")]
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
        /// Number of individual resources listed in the response per page
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

        /// <summary>
        /// Only list messages sent from this Short Code
        /// </summary>
        [JsonProperty("Shortcode")]
        public string Shortcode 
        { 
            get 
            {
                return this.shortcode; 
            } 
            set 
            {
                this.shortcode = value;
                onPropertyChanged("Shortcode");
            }
        }

        /// <summary>
        /// Only list messages sent to this number
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
        /// Only list SMS messages sent in the specified date range
        /// </summary>
        [JsonProperty("datesent")]
        public string Datesent 
        { 
            get 
            {
                return this.datesent; 
            } 
            set 
            {
                this.datesent = value;
                onPropertyChanged("Datesent");
            }
        }
    }
} 