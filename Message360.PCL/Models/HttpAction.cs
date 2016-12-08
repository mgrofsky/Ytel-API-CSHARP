/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 12/08/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using message360;
using message360.Utilities;

namespace message360.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum HttpAction
    {
        GET, //Get type
        POST, //Post Type
    }

    /// <summary>
    /// Helper for the enum type HttpAction
    /// </summary>
    public static class HttpActionHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "GET", "POST" };

        /// <summary>
        /// Converts a HttpAction value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The HttpAction value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(HttpAction enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case HttpAction.GET:
                case HttpAction.POST:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of HttpAction values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of HttpAction values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<HttpAction> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into HttpAction value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed HttpAction value</returns>
        public static HttpAction ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type HttpAction", value));

            return (HttpAction) index;
        }
    }
} 