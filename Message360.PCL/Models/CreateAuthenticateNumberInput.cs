/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 11/24/2016
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

namespace message360.Models
{
    public class CreateAuthenticateNumberInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string phoneNumber;
        private string accountSid;
        private string authToken;

        /// <summary>
        /// Phone number to authenticate for use
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber 
        { 
            get 
            {
                return this.phoneNumber; 
            } 
            set 
            {
                this.phoneNumber = value;
                onPropertyChanged("PhoneNumber");
            }
        }

        /// <summary>
        /// Your message360 Account SID
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
        /// Your message360 token
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