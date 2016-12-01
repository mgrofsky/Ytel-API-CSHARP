/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 12/01/2016
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
    public class CreateListInboundSMSInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? page;
        private string pagesize;
        private string mfrom;
        private string to;
        private string responseType = "json";

        /// <summary>
        /// Which page of the overall response will be returned. Zero indexed
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
        /// Number of individual resources listed in the response per page
        /// </summary>
        [JsonProperty("pagesize")]
        public string Pagesize 
        { 
            get 
            {
                return this.pagesize; 
            } 
            set 
            {
                this.pagesize = value;
                onPropertyChanged("Pagesize");
            }
        }

        /// <summary>
        /// From Number to Inbound SMS
        /// </summary>
        [JsonProperty("from")]
        public string From 
        { 
            get 
            {
                return this.mfrom; 
            } 
            set 
            {
                this.mfrom = value;
                onPropertyChanged("From");
            }
        }

        /// <summary>
        /// To Number to get Inbound SMS
        /// </summary>
        [JsonProperty("to")]
        public string To 
        { 
            get 
            {
                return this.to; 
            } 
            set 
            {
                this.to = value;
                onPropertyChanged("To");
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