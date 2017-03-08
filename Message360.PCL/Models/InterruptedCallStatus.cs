/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io )
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
    public enum InterruptedCallStatus
    {
        CANCELED, //Interrupt Call will be cancel
        COMPLETED, //Interrupt Call is complete
    }

    /// <summary>
    /// Helper for the enum type InterruptedCallStatus
    /// </summary>
    public static class InterruptedCallStatusHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "canceled", "completed" };

        /// <summary>
        /// Converts a InterruptedCallStatus value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The InterruptedCallStatus value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(InterruptedCallStatus enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case InterruptedCallStatus.CANCELED:
                case InterruptedCallStatus.COMPLETED:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of InterruptedCallStatus values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of InterruptedCallStatus values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<InterruptedCallStatus> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into InterruptedCallStatus value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed InterruptedCallStatus value</returns>
        public static InterruptedCallStatus ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type InterruptedCallStatus", value));

            return (InterruptedCallStatus) index;
        }
    }
} 