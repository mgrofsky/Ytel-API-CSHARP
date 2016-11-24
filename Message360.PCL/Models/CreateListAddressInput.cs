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
    public class CreateListAddressInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? page = 1;
        private int? pageSize = 10;
        private string addressId;
        private string dateCreated;
        private ResponseType? responseType = ResponseType.JSON;

        /// <summary>
        /// Return requested # of items starting the value, default=0, must be an integer
        /// </summary>
        [JsonProperty("page")]
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
        /// How many results to return, default=10, max 100, must be an integer
        /// </summary>
        [JsonProperty("pageSize")]
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
        /// addresses Sid
        /// </summary>
        [JsonProperty("addressId")]
        public string AddressId 
        { 
            get 
            {
                return this.addressId; 
            } 
            set 
            {
                this.addressId = value;
                onPropertyChanged("AddressId");
            }
        }

        /// <summary>
        /// date created address.
        /// </summary>
        [JsonProperty("dateCreated")]
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
        /// Response Type either json or xml
        /// </summary>
        [JsonProperty("ResponseType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public ResponseType? ResponseType 
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