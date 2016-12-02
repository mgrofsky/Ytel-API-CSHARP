/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 12/02/2016
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
    public class CreateDeafMuteParticipantInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string conferenceSid;
        private string participantSid;
        private bool? muted;
        private bool? deaf;
        private string responseType = "json";

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("conferenceSid")]
        public string ConferenceSid 
        { 
            get 
            {
                return this.conferenceSid; 
            } 
            set 
            {
                this.conferenceSid = value;
                onPropertyChanged("ConferenceSid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ParticipantSid")]
        public string ParticipantSid 
        { 
            get 
            {
                return this.participantSid; 
            } 
            set 
            {
                this.participantSid = value;
                onPropertyChanged("ParticipantSid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Muted")]
        public bool? Muted 
        { 
            get 
            {
                return this.muted; 
            } 
            set 
            {
                this.muted = value;
                onPropertyChanged("Muted");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Deaf")]
        public bool? Deaf 
        { 
            get 
            {
                return this.deaf; 
            } 
            set 
            {
                this.deaf = value;
                onPropertyChanged("Deaf");
            }
        }

        /// <summary>
        /// Response Type either json or xml
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