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
    public enum NumberType
    {
        ALL, //Get all phone Number type
        VOICE, //Get only voice number type
        SMS, //Get Only SMs number type
    }

    /// <summary>
    /// Helper for the enum type NumberType
    /// </summary>
    public static class NumberTypeHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "all", "voice", "sms" };

        /// <summary>
        /// Converts a NumberType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The NumberType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(NumberType enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case NumberType.ALL:
                case NumberType.VOICE:
                case NumberType.SMS:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of NumberType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of NumberType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<NumberType> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into NumberType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed NumberType value</returns>
        public static NumberType ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type NumberType", value));

            return (NumberType) index;
        }
    }
} 