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
    public class ErrorModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string code;
        private string message;
        private List<string> moreInfo;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Code")]
        public string Code 
        { 
            get 
            {
                return this.code; 
            } 
            set 
            {
                this.code = value;
                onPropertyChanged("Code");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MoreInfo")]
        public List<string> MoreInfo 
        { 
            get 
            {
                return this.moreInfo; 
            } 
            set 
            {
                this.moreInfo = value;
                onPropertyChanged("MoreInfo");
            }
        }
    }
} 