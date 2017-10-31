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
    public class TemplateDataModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string companyname;
        private string otpcode;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("companyname")]
        public string Companyname 
        { 
            get 
            {
                return this.companyname; 
            } 
            set 
            {
                this.companyname = value;
                onPropertyChanged("Companyname");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("otpcode")]
        public string Otpcode 
        { 
            get 
            {
                return this.otpcode; 
            } 
            set 
            {
                this.otpcode = value;
                onPropertyChanged("Otpcode");
            }
        }
    }
} 