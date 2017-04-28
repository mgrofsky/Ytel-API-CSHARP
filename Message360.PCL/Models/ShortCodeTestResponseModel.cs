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
    public class ShortCodeTestResponseModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.Message360Model message360;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Message360")]
        public Models.Message360Model Message360 
        { 
            get 
            {
                return this.message360; 
            } 
            set 
            {
                this.message360 = value;
                onPropertyChanged("Message360");
            }
        }
    }
} 