/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 11/04/2016
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
    public enum AudioDirection
    {
        IN, //TODO: Write general description for this method
        OUT, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type AudioDirection
    /// </summary>
    public static class AudioDirectionHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "in", "out" };

        /// <summary>
        /// Converts a AudioDirection value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The AudioDirection value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(AudioDirection enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case AudioDirection.IN:
                case AudioDirection.OUT:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of AudioDirection values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of AudioDirection values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<AudioDirection> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into AudioDirection value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed AudioDirection value</returns>
        public static AudioDirection ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type AudioDirection", value));

            return (AudioDirection) index;
        }
    }
} 