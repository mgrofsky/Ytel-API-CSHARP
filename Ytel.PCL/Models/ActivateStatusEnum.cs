/*
 * Ytel.PCL
 *
 * This file was automatically generated for ytel by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Linq;
using System.Collections.Generic;
using APIMATIC.SDK.Common;

namespace ytel.Models
{
    public enum ActivateStatusEnum
    {
        ACTIVATE = 1, //TODO: Write general description for this method
        DEACTIVATE = 0, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type ActivateStatusEnum
    /// </summary>
    public static class ActivateStatusEnumHelper
    {
        /// <summary>
        /// Convert a list of ActivateStatusEnum values to a list of integers
        /// </summary>
        /// <param name="enumValues">The list of ActivateStatusEnum values to convert</param>
        /// <returns>The list of representative integer values</returns>
        public static List<int> ToValue(List<ActivateStatusEnum> enumValues)
        {
            if (null == enumValues)
                return null;
            
            return enumValues.Select(eVal => (int)eVal).ToList();
        }
    }
} 