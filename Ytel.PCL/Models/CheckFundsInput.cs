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
    public class CheckFundsInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accountSid;
        private string authToken;

        /// <summary>
        /// Your Ytel Account SID
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid 
        { 
            get 
            {
                return this.accountSid; 
            } 
            set 
            {
                this.accountSid = value;
                onPropertyChanged("AccountSid");
            }
        }

        /// <summary>
        /// Your Ytel Token
        /// </summary>
        [JsonProperty("auth_token")]
        public string AuthToken 
        { 
            get 
            {
                return this.authToken; 
            } 
            set 
            {
                this.authToken = value;
                onPropertyChanged("AuthToken");
            }
        }
    }
} 