/*
 * Ytel.PCL
 *
 * This file was automatically generated for ytel by APIMATIC v2.0 ( https://apimatic.io )
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


namespace ytel.Models
{
    public class PlayAudioInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string callSid;
        private string audioUrl;
        private string sayText;
        private string responseType = "json";
        private int? length;
        private Models.DirectionEnum? direction;
        private bool? mix;

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
        /// URL to sound that should be played. You also can add more than one audio file using semicolons e.g. http://example.com/audio1.mp3;http://example.com/audio2.wav
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl 
        { 
            get 
            {
                return this.audioUrl; 
            } 
            set 
            {
                this.audioUrl = value;
                onPropertyChanged("AudioUrl");
            }
        }

        /// <summary>
        /// Valid alphanumeric string that should be played to the In-progress call.
        /// </summary>
        [JsonProperty("SayText")]
        public string SayText 
        { 
            get 
            {
                return this.sayText; 
            } 
            set 
            {
                this.sayText = value;
                onPropertyChanged("SayText");
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
        /// Time limit in seconds for audio play back
        /// </summary>
        [JsonProperty("Length")]
        public int? Length 
        { 
            get 
            {
                return this.length; 
            } 
            set 
            {
                this.length = value;
                onPropertyChanged("Length");
            }
        }

        /// <summary>
        /// The leg of the call audio will be played to
        /// </summary>
        [JsonProperty("Direction", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.DirectionEnum? Direction 
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
        /// If false, all other audio will be muted
        /// </summary>
        [JsonProperty("Mix")]
        public bool? Mix 
        { 
            get 
            {
                return this.mix; 
            } 
            set 
            {
                this.mix = value;
                onPropertyChanged("Mix");
            }
        }
    }
} 