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
    public class VoiceEffectInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string callSid;
        private string responseType = "json";
        private Models.AudioDirectionEnum? audioDirection;
        private double? pitchSemiTones;
        private double? pitchOctaves;
        private double? pitch;
        private double? rate;
        private double? tempo;

        /// <summary>
        /// The unique identifier for the in-progress voice call.
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
        /// The direction the audio effect should be placed on. If IN, the effects will occur on the incoming audio stream. If OUT, the effects will occur on the outgoing audio stream.
        /// </summary>
        [JsonProperty("AudioDirection", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.AudioDirectionEnum? AudioDirection 
        { 
            get 
            {
                return this.audioDirection; 
            } 
            set 
            {
                this.audioDirection = value;
                onPropertyChanged("AudioDirection");
            }
        }

        /// <summary>
        /// Set the pitch in semitone (half-step) intervals. Value between -14 and 14
        /// </summary>
        [JsonProperty("PitchSemiTones")]
        public double? PitchSemiTones 
        { 
            get 
            {
                return this.pitchSemiTones; 
            } 
            set 
            {
                this.pitchSemiTones = value;
                onPropertyChanged("PitchSemiTones");
            }
        }

        /// <summary>
        /// Set the pitch in octave intervals.. Value between -1 and 1
        /// </summary>
        [JsonProperty("PitchOctaves")]
        public double? PitchOctaves 
        { 
            get 
            {
                return this.pitchOctaves; 
            } 
            set 
            {
                this.pitchOctaves = value;
                onPropertyChanged("PitchOctaves");
            }
        }

        /// <summary>
        /// Set the pitch (lowness/highness) of the audio. The higher the value, the higher the pitch. Value greater than 0
        /// </summary>
        [JsonProperty("Pitch")]
        public double? Pitch 
        { 
            get 
            {
                return this.pitch; 
            } 
            set 
            {
                this.pitch = value;
                onPropertyChanged("Pitch");
            }
        }

        /// <summary>
        /// Set the rate for audio. The lower the value, the lower the rate. value greater than 0
        /// </summary>
        [JsonProperty("Rate")]
        public double? Rate 
        { 
            get 
            {
                return this.rate; 
            } 
            set 
            {
                this.rate = value;
                onPropertyChanged("Rate");
            }
        }

        /// <summary>
        /// Set the tempo (speed) of the audio. A higher value denotes a faster tempo. Value greater than 0
        /// </summary>
        [JsonProperty("Tempo")]
        public double? Tempo 
        { 
            get 
            {
                return this.tempo; 
            } 
            set 
            {
                this.tempo = value;
                onPropertyChanged("Tempo");
            }
        }
    }
} 