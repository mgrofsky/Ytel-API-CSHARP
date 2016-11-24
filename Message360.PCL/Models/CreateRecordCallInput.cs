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
    public class CreateRecordCallInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string callSid;
        private bool record;
        private Direction? direction;
        private int? timeLimit;
        private string callBackUrl;
        private AudioFormat? fileformat;
        private string responseType = "json";

        /// <summary>
        /// The unique identifier of each call resource
        /// </summary>
        [JsonProperty("CallSid")]
        public string CallSid 
        { 
            get 
            {
                return this.callSid; 
            } 
            set 
            {
                this.callSid = value;
                onPropertyChanged("CallSid");
            }
        }

        /// <summary>
        /// Set true to initiate recording or false to terminate recording
        /// </summary>
        [JsonProperty("Record")]
        public bool Record 
        { 
            get 
            {
                return this.record; 
            } 
            set 
            {
                this.record = value;
                onPropertyChanged("Record");
            }
        }

        /// <summary>
        /// The leg of the call to record
        /// </summary>
        [JsonProperty("Direction", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Direction? Direction 
        { 
            get 
            {
                return this.direction; 
            } 
            set 
            {
                this.direction = value;
                onPropertyChanged("Direction");
            }
        }

        /// <summary>
        /// Time in seconds the recording duration should not exceed
        /// </summary>
        [JsonProperty("TimeLimit")]
        public int? TimeLimit 
        { 
            get 
            {
                return this.timeLimit; 
            } 
            set 
            {
                this.timeLimit = value;
                onPropertyChanged("TimeLimit");
            }
        }

        /// <summary>
        /// URL consulted after the recording completes
        /// </summary>
        [JsonProperty("CallBackUrl")]
        public string CallBackUrl 
        { 
            get 
            {
                return this.callBackUrl; 
            } 
            set 
            {
                this.callBackUrl = value;
                onPropertyChanged("CallBackUrl");
            }
        }

        /// <summary>
        /// Format of the recording file. Can be .mp3 or .wav
        /// </summary>
        [JsonProperty("Fileformat", ItemConverterType = typeof(StringValuedEnumConverter))]
        public AudioFormat? Fileformat 
        { 
            get 
            {
                return this.fileformat; 
            } 
            set 
            {
                this.fileformat = value;
                onPropertyChanged("Fileformat");
            }
        }

        /// <summary>
        /// Response format, xml or json
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