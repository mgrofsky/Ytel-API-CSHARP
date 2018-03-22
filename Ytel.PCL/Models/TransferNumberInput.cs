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
    public class TransferNumberInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string phonenumber;
        private string fromaccountsid;
        private string toaccountsid;
        private string responseType = "json";

        /// <summary>
        /// A valid 10-digit Ytel number (E.164 format).
        /// </summary>
        [JsonProperty("phonenumber")]
        public string Phonenumber 
        { 
            get 
            {
                return this.phonenumber; 
            } 
            set 
            {
                this.phonenumber = value;
                onPropertyChanged("Phonenumber");
            }
        }

        /// <summary>
        /// A specific Accountsid from where Number is getting transfer.
        /// </summary>
        [JsonProperty("fromaccountsid")]
        public string Fromaccountsid 
        { 
            get 
            {
                return this.fromaccountsid; 
            } 
            set 
            {
                this.fromaccountsid = value;
                onPropertyChanged("Fromaccountsid");
            }
        }

        /// <summary>
        /// A specific Accountsid to which Number is getting transfer.
        /// </summary>
        [JsonProperty("toaccountsid")]
        public string Toaccountsid 
        { 
            get 
            {
                return this.toaccountsid; 
            } 
            set 
            {
                this.toaccountsid = value;
                onPropertyChanged("Toaccountsid");
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