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
    public class ErrorsModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.ErrorModel> error;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Error")]
        public List<Models.ErrorModel> Error 
        { 
            get 
            {
                return this.error; 
            } 
            set 
            {
                this.error = value;
                onPropertyChanged("Error");
            }
        }
    }
} 