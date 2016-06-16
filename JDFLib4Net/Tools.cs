using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JDFLib4Net
{
    public class Tools
    {
        /// <summary>
        /// validate the string is a Double
        /// </summary>
        /// <param name="vle">string value</param>
        /// <returns>double</returns>
        public static double ValidateDouble(string vle)
        {
            double result = 0;
            if (!String.IsNullOrEmpty(vle))
            {
                double value;
                if (Double.TryParse(vle, out value))
                    result = value;
            }
            return result;
        }

        public static string SetEnumValue(Type En, object value)
        {
            if (Enum.IsDefined(En, value))
                return value.ToString();
            else
                return En.GetEnumValues().GetValue(0).ToString();
        }

        public static string ValidateString(string[] En, object value)
        {
            if (En.Contains(value))
                return value.ToString();
            else
                return En[0].ToString();
        }


        public static bool SetBool(string vle)
        {
            string[] isFalse = { "0", "off", "no", "false" };
            string[] isTrue = { "1", "on", "yes", "true" };
            if (isFalse.Contains(vle, StringComparer.InvariantCultureIgnoreCase))
                return false;
            else if (isTrue.Contains(vle, StringComparer.InvariantCultureIgnoreCase))
                return true;
            else
                throw new ArgumentException("Unable to set Boolean Value.");
        }

        public static string ValidatePDFPath(string value)
        {
            if (Regex.IsMatch(value, @"^((([+\-]?\d+(\.\d+)?\s){2}[ml]|([+\-]?\d+(\.\d+)?\s){6}c|([+\-]?\d+(\.\d+)?\s){4}([vy]|re)|h)(\s(([+\-]?\d+(\.\d+)?\s){2}[ml]|([+\-]?\d+(\.\d+)?\s){6}c|([+\-]?\d+(\.\d+)?\s){4}([vy]|re)|h))*)$", RegexOptions.IgnoreCase))
                return value;
            else
                throw new ArgumentException("Unable to Confirm PDFPath");
        }
    }
}
