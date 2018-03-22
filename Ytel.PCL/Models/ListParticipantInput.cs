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
    public class ListParticipantInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string conferenceSid;
        private string responseType = "json";
        private int? page = 1;
        private int? pagesize = 10;
        private bool? muted;
        private bool? deaf;

        /// <summary>
        /// The unique identifier for a conference.
        /// </summary>
        [JsonProperty("ConferenceSid")]
        public string ConferenceSid 
        { 
            get 
            {
                return this.conferenceSid; 
            } 
            set 
            {
                this.conferenceSid = value;
                onPropertyChanged("ConferenceSid");
            }
        }

        /// <summary>
        /// Response format, xml or json
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
        [JsonProperty("Pagesize")]
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
        /// Specifies if participant should be muted.
        /// </summary>
        [JsonProperty("Muted")]
        public bool? Muted 
        { 
            get 
            {
                return this.muted; 
            } 
            set 
            {
                this.muted = value;
                onPropertyChanged("Muted");
            }
        }

        /// <summary>
        /// Specifies if the participant should hear audio in the conference.
        /// </summary>
        [JsonProperty("Deaf")]
        public bool? Deaf 
        { 
            get 
            {
                return this.deaf; 
            } 
            set 
            {
                this.deaf = value;
                onPropertyChanged("Deaf");
            }
        }
    }
} 