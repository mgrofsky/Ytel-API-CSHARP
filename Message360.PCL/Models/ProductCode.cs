/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 11/24/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using message360;

namespace message360.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum ProductCode
    {
        ALL, //TODO: Write general description for this method
        OUTBOUND_CALL, //TODO: Write general description for this method
        INBOUND_CALL, //TODO: Write general description for this method
        OUTBOUND_SMS, //TODO: Write general description for this method
        INBOUND_SMS, //TODO: Write general description for this method
        TRANSCRIPTION, //TODO: Write general description for this method
        EMAIL, //TODO: Write general description for this method
        CONFERENCE, //TODO: Write general description for this method
        CARRIER, //TODO: Write general description for this method
        NUMBER_PURCHASED, //TODO: Write general description for this method
        DIRECT_MAIL_AREAMAIL, //TODO: Write general description for this method
        DIRECT_MAIL_POSTCARD, //TODO: Write general description for this method
        DIRECT_MAIL_LETTERS, //TODO: Write general description for this method
        DIRECT_MAIL_VERIFIED_ADDRESS, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type ProductCode
    /// </summary>
    public static class ProductCodeHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };

        /// <summary>
        /// Converts a ProductCode value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The ProductCode value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(ProductCode enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case ProductCode.ALL:
                case ProductCode.OUTBOUND_CALL:
                case ProductCode.INBOUND_CALL:
                case ProductCode.OUTBOUND_SMS:
                case ProductCode.INBOUND_SMS:
                case ProductCode.TRANSCRIPTION:
                case ProductCode.EMAIL:
                case ProductCode.CONFERENCE:
                case ProductCode.CARRIER:
                case ProductCode.NUMBER_PURCHASED:
                case ProductCode.DIRECT_MAIL_AREAMAIL:
                case ProductCode.DIRECT_MAIL_POSTCARD:
                case ProductCode.DIRECT_MAIL_LETTERS:
                case ProductCode.DIRECT_MAIL_VERIFIED_ADDRESS:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of ProductCode values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of ProductCode values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<ProductCode> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into ProductCode value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed ProductCode value</returns>
        public static ProductCode ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type ProductCode", value));

            return (ProductCode) index;
        }
    }
} 