/*
 * Ytel.PCL
 *
 * This file was automatically generated for ytel by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;

namespace ytel.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum InterruptedCallStatusEnum
    {
        CANCELED, //Interrupt Call will be cancel
        COMPLETED, //Interrupt Call is complete
    }

    /// <summary>
    /// Helper for the enum type InterruptedCallStatusEnum
    /// </summary>
    public static class InterruptedCallStatusEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "canceled", "completed" };

        /// <summary>
        /// Converts a InterruptedCallStatusEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The InterruptedCallStatusEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(InterruptedCallStatusEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case InterruptedCallStatusEnum.CANCELED:
                case InterruptedCallStatusEnum.COMPLETED:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of InterruptedCallStatusEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of InterruptedCallStatusEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<InterruptedCallStatusEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into InterruptedCallStatusEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed InterruptedCallStatusEnum value</returns>
        public static InterruptedCallStatusEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type InterruptedCallStatusEnum", value));

            return (InterruptedCallStatusEnum) index;
        }
    }
} 