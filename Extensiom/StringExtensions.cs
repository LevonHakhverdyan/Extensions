using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class StringExtensions
    {
        
            public static bool GetCharElement(this string sourse, out char result)
            {
                result = default(char);
                bool hasElements = false;
                if (sourse != null && sourse.Any())
                {
                    hasElements = true;
                    result = sourse[3];
                }



                return hasElements;
            }
        

    }
}
