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
    public class CreateSuspendSubAccountInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string subAccountSID;
        private Models.ActivateStatusEnum activate = ActivateStatusEnum.DEACTIVATE;
        private string responseType;

        /// <summary>
        /// The SubaccountSid to be activated or suspended
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
        /// 0 to suspend or 1 to activate
        /// </summary>
        [JsonProperty("Activate")]
        public Models.ActivateStatusEnum Activate 
        { 
            get 
            {
                return this.activate; 
            } 
            set 
            {
                this.activate = value;
                onPropertyChanged("Activate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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