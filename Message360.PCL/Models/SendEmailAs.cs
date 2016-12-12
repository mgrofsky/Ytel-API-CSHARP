/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 12/12/2016
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
    public enum SendEmailAs
    {
        TEXT, //Email send as text format
        HTML, //Email send as HTML format
    }

    /// <summary>
    /// Helper for the enum type SendEmailAs
    /// </summary>
    public static class SendEmailAsHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "text", "html" };

        /// <summary>
        /// Converts a SendEmailAs value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SendEmailAs value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SendEmailAs enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SendEmailAs.TEXT:
                case SendEmailAs.HTML:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SendEmailAs values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SendEmailAs values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SendEmailAs> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into SendEmailAs value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SendEmailAs value</returns>
        public static SendEmailAs ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type SendEmailAs", value));

            return (SendEmailAs) index;
        }
    }
} 