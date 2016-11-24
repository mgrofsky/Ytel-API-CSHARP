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
    public enum ResponseType
    {
        JSON, //json format
        XML, //xml format
    }

    /// <summary>
    /// Helper for the enum type ResponseType
    /// </summary>
    public static class ResponseTypeHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "json", "xml" };

        /// <summary>
        /// Converts a ResponseType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The ResponseType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(ResponseType enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case ResponseType.JSON:
                case ResponseType.XML:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of ResponseType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of ResponseType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<ResponseType> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into ResponseType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed ResponseType value</returns>
        public static ResponseType ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type ResponseType", value));

            return (ResponseType) index;
        }
    }
} 