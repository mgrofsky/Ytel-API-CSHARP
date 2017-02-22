/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 02/22/2017
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
    public class CreateSuspendSubAccountInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string subAccountSID;
        private Models.ActivateStatus activate = ActivateStatus.DEACTIVATE;
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
        public Models.ActivateStatus Activate 
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

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 