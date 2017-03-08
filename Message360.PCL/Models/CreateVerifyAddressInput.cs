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
using message360;
using message360.Utilities;

namespace message360.Models
{
    public class CreateVerifyAddressInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string addressSID;
        private string responseType = "json";

        /// <summary>
        /// The identifier of the address to be verified.
        /// </summary>
        [JsonProperty("AddressSID")]
        public string AddressSID 
        { 
            get 
            {
                return this.addressSID; 
            } 
            set 
            {
                this.addressSID = value;
                onPropertyChanged("AddressSID");
            }
        }

        /// <summary>
        /// Response type either json or xml
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