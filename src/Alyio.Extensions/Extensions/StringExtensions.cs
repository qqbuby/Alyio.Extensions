﻿using System;

namespace Alyio.Extensions
{
    /// <summary>
    /// Extension methods for converting a <see cref="string"/> type to another base data type.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts the specified string representation of a number to an equivalent 32-bit signed integer.
        /// </summary>
        /// <param name="value">A string that contains a number to convert.</param>
        /// <returns>A 32-bit signed integer that is equivalent to the number in value, or null if value is null or was not converted successfully.</returns>
        public static int? ToInt32(this string value)
        {
            if (int.TryParse(value, out int result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Converts the specified string representation of a number to an equivalent 32-bit signed integer.
        /// </summary>
        /// <param name="value">A string that contains a number to convert.</param>
        /// <returns>A 64-bit signed integer that is equivalent to the number in value, or null if value is null or was not converted successfully.</returns>
        public static long? ToInt64(this string value)
        {
            if (long.TryParse(value, out long result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Converts the specified string representation of a number to an equivalent double-precision floating-point number.
        /// </summary>
        /// <param name="value">A string that contains a number to convert.</param>
        /// <returns>A double-precision floating-point number that is equivalent to the number in value, or null if value is null was not converted successfully.</returns>
        public static double? ToDouble(this string value)
        {
            if (double.TryParse(value, out double result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Converts the specified string representation of a number to an equivalent decimal number.
        /// </summary>
        /// <param name="value">A string that contains a number to convert.</param>
        /// <returns>A decimal number that is equivalent to the number in value, or null if value is null or was not converted successfully.</returns>
        public static decimal? ToDecimal(this string value)
        {
            if (decimal.TryParse(value, out decimal result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Converts the specified string representation of a date and time to an equivalent date and time, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="value">A string that contains a date and time to convert.</param>
        /// <returns>The date and time equivalent of the value of value, or null if value is null or was not converted successfully.</returns>
        public static DateTime? ToDateTime(this string value)
        {
            if (DateTime.TryParse(value, out DateTime dateTime))
            {
                return dateTime;
            }
            else
            {
                return null;
            }
        }
    }
}
