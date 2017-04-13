/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Linq;
using System.Collections.Generic;
using APIMATIC.SDK.Common;

namespace message360.Models
{
    public enum ProductCodeEnum
    {
        ALL = 0, //TODO: Write general description for this method
        OUTBOUND_CALL = 1, //TODO: Write general description for this method
        INBOUND_CALL = 2, //TODO: Write general description for this method
        OUTBOUND_SMS = 3, //TODO: Write general description for this method
        INBOUND_SMS = 4, //TODO: Write general description for this method
        TRANSCRIPTION = 5, //TODO: Write general description for this method
        EMAIL = 6, //TODO: Write general description for this method
        CONFERENCE = 7, //TODO: Write general description for this method
        CARRIER = 8, //TODO: Write general description for this method
        NUMBER_PURCHASED = 9, //TODO: Write general description for this method
        DIRECT_MAIL_AREAMAIL = 10, //TODO: Write general description for this method
        DIRECT_MAIL_POSTCARD = 11, //TODO: Write general description for this method
        DIRECT_MAIL_LETTERS = 12, //TODO: Write general description for this method
        DIRECT_MAIL_VERIFIED_ADDRESS = 13, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type ProductCodeEnum
    /// </summary>
    public static class ProductCodeEnumHelper
    {
        /// <summary>
        /// Convert a list of ProductCodeEnum values to a list of integers
        /// </summary>
        /// <param name="enumValues">The list of ProductCodeEnum values to convert</param>
        /// <returns>The list of representative integer values</returns>
        public static List<int> ToValue(List<ProductCodeEnum> enumValues)
        {
            if (null == enumValues)
                return null;
            
            return enumValues.Select(eVal => (int)eVal).ToList();
        }
    }
} 