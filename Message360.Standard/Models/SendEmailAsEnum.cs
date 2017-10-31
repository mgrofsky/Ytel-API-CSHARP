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
    public enum SendEmailAsEnum
    {
        TEXT, //Email send as text format
        HTML, //Email send as HTML format
    }

    /// <summary>
    /// Helper for the enum type SendEmailAsEnum
    /// </summary>
    public static class SendEmailAsEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "text", "html" };

        /// <summary>
        /// Converts a SendEmailAsEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SendEmailAsEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SendEmailAsEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SendEmailAsEnum.TEXT:
                case SendEmailAsEnum.HTML:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SendEmailAsEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SendEmailAsEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SendEmailAsEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into SendEmailAsEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SendEmailAsEnum value</returns>
        public static SendEmailAsEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type SendEmailAsEnum", value));

            return (SendEmailAsEnum) index;
        }
    }
} 