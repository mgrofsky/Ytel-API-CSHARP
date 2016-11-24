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
    public class CreateAvailablePhoneNumberInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private NumberType numberType;
        private string areaCode;
        private int? pageSize;
        private ResponseType? responseType = ResponseType.JSON;

        /// <summary>
        /// Number type either SMS,Voice or all
        /// </summary>
        [JsonProperty("NumberType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public NumberType NumberType 
        { 
            get 
            {
                return this.numberType; 
            } 
            set 
            {
                this.numberType = value;
                onPropertyChanged("NumberType");
            }
        }

        /// <summary>
        /// Phone Number Area Code
        /// </summary>
        [JsonProperty("AreaCode")]
        public string AreaCode 
        { 
            get 
            {
                return this.areaCode; 
            } 
            set 
            {
                this.areaCode = value;
                onPropertyChanged("AreaCode");
            }
        }

        /// <summary>
        /// Page Size
        /// </summary>
        [JsonProperty("PageSize")]
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
        /// Response format, xml or json
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