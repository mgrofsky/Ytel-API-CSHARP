/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 12/02/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using message360;
using message360.Utilities;

namespace message360.Models
{
    public enum ActivateStatus
    {
        ACTIVATE = 1, //TODO: Write general description for this method
        DEACTIVATE = 0, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type ActivateStatus
    /// </summary>
    public static class ActivateStatusHelper
    {
        /// <summary>
        /// Convert a list of ActivateStatus values to a list of integers
        /// </summary>
        /// <param name="enumValues">The list of ActivateStatus values to convert</param>
        /// <returns>The list of representative integer values</returns>
        public static List<int> ToValue(List<ActivateStatus> enumValues)
        {
            if (null == enumValues)
                return null;
            
            return enumValues.Select(eVal => (int)eVal).ToList();
        }
    }
} 