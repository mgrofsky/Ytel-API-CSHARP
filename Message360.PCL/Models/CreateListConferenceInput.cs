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
    public class CreateListConferenceInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string responseType = "json";
        private int? page;
        private int? pageSize;
        private string friendlyName;
        private Models.InterruptedCallStatusEnum? status;
        private string dateCreated;
        private string dateUpdated;

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
        /// Which page of the overall response will be returned. Zero indexed
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
        /// Number of individual resources listed in the response per page
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

        /// <summary>
        /// Only return conferences with the specified FriendlyName
        /// </summary>
        [JsonProperty("FriendlyName")]
        public string FriendlyName 
        { 
            get 
            {
                return this.friendlyName; 
            } 
            set 
            {
                this.friendlyName = value;
                onPropertyChanged("FriendlyName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.InterruptedCallStatusEnum? Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DateCreated")]
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

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DateUpdated")]
        public string DateUpdated 
        { 
            get 
            {
                return this.dateUpdated; 
            } 
            set 
            {
                this.dateUpdated = value;
                onPropertyChanged("DateUpdated");
            }
        }
    }
} 