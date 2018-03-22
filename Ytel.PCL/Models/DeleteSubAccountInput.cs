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
    public class DeleteSubAccountInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string subAccountSID;
        private Models.MergeNumberStatusEnum mergeNumber = Models.MergeNumberStatusEnum.DELETE;
        private string responseType = "json";

        /// <summary>
        /// The SubaccountSid to be deleted
        /// </summary>
        [JsonProperty("SubAccountSID")]
        public string SubAccountSID 
        { 
            get 
            {
                return this.subAccountSID; 
            } 
            set 
            {
                this.subAccountSID = value;
                onPropertyChanged("SubAccountSID");
            }
        }

        /// <summary>
        /// 0 to delete or 1 to merge numbers to parent account.
        /// </summary>
        [JsonProperty("MergeNumber")]
        public Models.MergeNumberStatusEnum MergeNumber 
        { 
            get 
            {
                return this.mergeNumber; 
            } 
            set 
            {
                this.mergeNumber = value;
                onPropertyChanged("MergeNumber");
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
    }
} 