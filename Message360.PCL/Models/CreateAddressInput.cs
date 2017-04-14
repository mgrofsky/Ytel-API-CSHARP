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
    public class CreateAddressInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string address;
        private string country;
        private string state;
        private string city;
        private string zip;
        private string description;
        private string email;
        private string phone;
        private string responseType = "json";

        /// <summary>
        /// Name of user
        /// </summary>
        [JsonProperty("Name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Address of user.
        /// </summary>
        [JsonProperty("Address")]
        public string Address 
        { 
            get 
            {
                return this.address; 
            } 
            set 
            {
                this.address = value;
                onPropertyChanged("Address");
            }
        }

        /// <summary>
        /// Must be a 2 letter country short-name code (ISO 3166)
        /// </summary>
        [JsonProperty("Country")]
        public string Country 
        { 
            get 
            {
                return this.country; 
            } 
            set 
            {
                this.country = value;
                onPropertyChanged("Country");
            }
        }

        /// <summary>
        /// Must be a 2 letter State eg. CA for US. For Some Countries it can be greater than 2 letters.
        /// </summary>
        [JsonProperty("State")]
        public string State 
        { 
            get 
            {
                return this.state; 
            } 
            set 
            {
                this.state = value;
                onPropertyChanged("State");
            }
        }

        /// <summary>
        /// City Name.
        /// </summary>
        [JsonProperty("City")]
        public string City 
        { 
            get 
            {
                return this.city; 
            } 
            set 
            {
                this.city = value;
                onPropertyChanged("City");
            }
        }

        /// <summary>
        /// Zip code of city.
        /// </summary>
        [JsonProperty("Zip")]
        public string Zip 
        { 
            get 
            {
                return this.zip; 
            } 
            set 
            {
                this.zip = value;
                onPropertyChanged("Zip");
            }
        }

        /// <summary>
        /// Description of addresses.
        /// </summary>
        [JsonProperty("Description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Email Id of user.
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Phone number of user.
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone 
        { 
            get 
            {
                return this.phone; 
            } 
            set 
            {
                this.phone = value;
                onPropertyChanged("Phone");
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