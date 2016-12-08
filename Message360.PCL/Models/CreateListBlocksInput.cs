/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 12/08/2016
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
    public class CreateListBlocksInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string offset;
        private string limit;
        private string responseType = "json";

        /// <summary>
        /// Where to start in the output list
        /// </summary>
        [JsonProperty("offset")]
        public string Offset 
        { 
            get 
            {
                return this.offset; 
            } 
            set 
            {
                this.offset = value;
                onPropertyChanged("Offset");
            }
        }

        /// <summary>
        /// Maximum number of records to return
        /// </summary>
        [JsonProperty("limit")]
        public string Limit 
        { 
            get 
            {
                return this.limit; 
            } 
            set 
            {
                this.limit = value;
                onPropertyChanged("Limit");
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