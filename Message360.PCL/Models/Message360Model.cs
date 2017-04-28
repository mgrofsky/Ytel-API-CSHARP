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
    public class Message360Model : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int responseStatus;
        private int messageCount;
        private Models.MessageModel message;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ResponseStatus")]
        public int ResponseStatus 
        { 
            get 
            {
                return this.responseStatus; 
            } 
            set 
            {
                this.responseStatus = value;
                onPropertyChanged("ResponseStatus");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MessageCount")]
        public int MessageCount 
        { 
            get 
            {
                return this.messageCount; 
            } 
            set 
            {
                this.messageCount = value;
                onPropertyChanged("MessageCount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Message")]
        public Models.MessageModel Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }
    }
} 