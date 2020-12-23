using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    // 1. add 'static' keyword to the class in question
    // 2. 'this' keyword should preceed the type we are extending in the input parameter,
    // and it should be passed as the fist parameter to the function
    public static class StringHelper
    {
        public static string ToggleFirstLetterCase(this string inputString )
        {
            if (inputString.Length <= 0) return inputString;
            var charArray = inputString.ToCharArray();
            charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
            return new string(charArray);

        }
    }
}
