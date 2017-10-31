/*
 * Message360.Standard
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
    public class AddParticipantInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string conferencesid;
        private string participantnumber;
        private string responseType = "json";
        private bool? muted;
        private bool? deaf;

        /// <summary>
        /// Unique Conference Sid
        /// </summary>
        [JsonProperty("conferencesid")]
        public string Conferencesid 
        { 
            get 
            {
                return this.conferencesid; 
            } 
            set 
            {
                this.conferencesid = value;
                onPropertyChanged("Conferencesid");
            }
        }

        /// <summary>
        /// Particiant Number
        /// </summary>
        [JsonProperty("participantnumber")]
        public string Participantnumber 
        { 
            get 
            {
                return this.participantnumber; 
            } 
            set 
            {
                this.participantnumber = value;
                onPropertyChanged("Participantnumber");
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
        /// add muted
        /// </summary>
        [JsonProperty("muted")]
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
        /// add without volume
        /// </summary>
        [JsonProperty("deaf")]
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
    }
} 