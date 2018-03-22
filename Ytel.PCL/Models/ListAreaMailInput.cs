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
    public class ListAreaMailInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string responseType = "json";
        private int? page = 1;
        private int? pagesize = 10;
        private string areamailsid;
        private string dateCreated;

        /// <summary>
        /// Response Type either json or xml
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
        /// The count of objects to return per page.
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
        /// The unique identifier for an AreaMail object.
        /// </summary>
        [JsonProperty("areamailsid")]
        public string Areamailsid 
        { 
            get 
            {
                return this.areamailsid; 
            } 
            set 
            {
                this.areamailsid = value;
                onPropertyChanged("Areamailsid");
            }
        }

        /// <summary>
        /// The date the AreaMail was created.
        /// </summary>
        [JsonProperty("dateCreated")]
        public string DateCreated 
        { 
            get 
            {
                return this.dateCreated; 
            } 
            set 
            {
                this.dateCreated = value;
                onPropertyChanged("DateCreated");
            }
        }
    }
} 