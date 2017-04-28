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
    public class MessageModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string apiVersion;
        private string messageSid;
        private string mfrom;
        private string to;
        private string messagePrice;
        private string body;
        private string dateSent;
        private string status;
        private string templateId;
        private Models.TemplateDataModel templateData;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ApiVersion")]
        public string ApiVersion 
        { 
            get 
            {
                return this.apiVersion; 
            } 
            set 
            {
                this.apiVersion = value;
                onPropertyChanged("ApiVersion");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MessageSid")]
        public string MessageSid 
        { 
            get 
            {
                return this.messageSid; 
            } 
            set 
            {
                this.messageSid = value;
                onPropertyChanged("MessageSid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("From")]
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("To")]
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MessagePrice")]
        public string MessagePrice 
        { 
            get 
            {
                return this.messagePrice; 
            } 
            set 
            {
                this.messagePrice = value;
                onPropertyChanged("MessagePrice");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Body")]
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DateSent")]
        public string DateSent 
        { 
            get 
            {
                return this.dateSent; 
            } 
            set 
            {
                this.dateSent = value;
                onPropertyChanged("DateSent");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId 
        { 
            get 
            {
                return this.templateId; 
            } 
            set 
            {
                this.templateId = value;
                onPropertyChanged("TemplateId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TemplateData")]
        public Models.TemplateDataModel TemplateData 
        { 
            get 
            {
                return this.templateData; 
            } 
            set 
            {
                this.templateData = value;
                onPropertyChanged("TemplateData");
            }
        }
    }
} 