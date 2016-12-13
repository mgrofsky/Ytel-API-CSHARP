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
    public enum Status
    {
        INPROGRESS, //TODO: Write general description for this method
        SUCCESS, //TODO: Write general description for this method
        FAILURE, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Status
    /// </summary>
    public static class StatusHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "inprogress", "success", "failure" };

        /// <summary>
        /// Converts a Status value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Status value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Status enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Status.INPROGRESS:
                case Status.SUCCESS:
                case Status.FAILURE:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Status values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Status values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Status> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into Status value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Status value</returns>
        public static Status ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type Status", value));

            return (Status) index;
        }
    }
} 