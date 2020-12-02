using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayer
{
    //Singleton Pattern
    public static class Common
    {
        public enum FiboType
        {
            Iterative = 1,
            Recursive = 2
        }

        /// <summary>
        /// Function to check is input string is valid integer or not
        /// </summary>
        /// <param name="s">input string</param>
        /// <returns>boolean</returns>
        public static bool isStringValidInteger(string s)
        {
            int n;
            var isNumeric = int.TryParse(s, out n);

            if (isNumeric)
                return true;
            
            return false;
        }

    }
}
