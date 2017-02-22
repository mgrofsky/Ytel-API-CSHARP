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
    public class CreateDeleteSubAccountInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string subAccountSID;
        private Models.MergeNumberStatus mergeNumber = MergeNumberStatus.DELETE;
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
        public Models.MergeNumberStatus MergeNumber 
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