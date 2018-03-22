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
    public class ListInboundShortcodeInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string responseType = "json";
        private int? page = 1;
        private int? pagesize = 10;
        private string mfrom;
        private string shortcode;
        private string datecreated;

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
        /// Only list SMS messages sent from this number
        /// </summary>
        [JsonProperty("From")]
        public string From 
        { 
            get 
            {
                return this.mfrom; 
            } 
            set 
            {
                this.mfrom = value;
                onPropertyChanged("From");
            }
        }

        /// <summary>
        /// Only list SMS messages sent to Shortcode
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
        /// Only list SMS messages sent in the specified date MAKE REQUEST
        /// </summary>
        [JsonProperty("Datecreated")]
        public string Datecreated 
        { 
            get 
            {
                return this.datecreated; 
            } 
            set 
            {
                this.datecreated = value;
                onPropertyChanged("Datecreated");
            }
        }
    }
} 