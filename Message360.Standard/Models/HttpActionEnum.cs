/*
 * Message360.Standard
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;

namespace message360.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum HttpActionEnum
    {
        GET, //Get type
        POST, //Post Type
    }

    /// <summary>
    /// Helper for the enum type HttpActionEnum
    /// </summary>
    public static class HttpActionEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "GET", "POST" };

        /// <summary>
        /// Converts a HttpActionEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The HttpActionEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(HttpActionEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case HttpActionEnum.GET:
                case HttpActionEnum.POST:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of HttpActionEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of HttpActionEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<HttpActionEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into HttpActionEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed HttpActionEnum value</returns>
        public static HttpActionEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type HttpActionEnum", value));

            return (HttpActionEnum) index;
        }
    }
} 