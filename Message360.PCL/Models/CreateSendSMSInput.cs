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
    public class CreateSendSMSInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int fromcountrycode = 1;
        private string mfrom;
        private int tocountrycode = 1;
        private string to;
        private string body;
        private HttpAction? method;
        private string messagestatuscallback;
        private string responseType = "json";

        /// <summary>
        /// From Country Code
        /// </summary>
        [JsonProperty("fromcountrycode")]
        public int Fromcountrycode 
        { 
            get 
            {
                return this.fromcountrycode; 
            } 
            set 
            {
                this.fromcountrycode = value;
                onPropertyChanged("Fromcountrycode");
            }
        }

        /// <summary>
        /// SMS enabled Message360 number to send this message from
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
        /// To country code
        /// </summary>
        [JsonProperty("tocountrycode")]
        public int Tocountrycode 
        { 
            get 
            {
                return this.tocountrycode; 
            } 
            set 
            {
                this.tocountrycode = value;
                onPropertyChanged("Tocountrycode");
            }
        }

        /// <summary>
        /// Number to send the SMS to
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
        /// Text Message To Send
        /// </summary>
        [JsonProperty("body")]
        public string Body 
        { 
            get 
            {
                return this.body; 
            } 
            set 
            {
                this.body = value;
                onPropertyChanged("Body");
            }
        }

        /// <summary>
        /// Specifies the HTTP method used to request the required URL once SMS sent.
        /// </summary>
        [JsonProperty("method", ItemConverterType = typeof(StringValuedEnumConverter))]
        public HttpAction? Method 
        { 
            get 
            {
                return this.method; 
            } 
            set 
            {
                this.method = value;
                onPropertyChanged("Method");
            }
        }

        /// <summary>
        /// URL that can be requested to receive notification when SMS has Sent. A set of default parameters will be sent here once the SMS is finished.
        /// </summary>
        [JsonProperty("messagestatuscallback")]
        public string Messagestatuscallback 
        { 
            get 
            {
                return this.messagestatuscallback; 
            } 
            set 
            {
                this.messagestatuscallback = value;
                onPropertyChanged("Messagestatuscallback");
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