using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
   public static  class ListExtensions
    {
        public static bool GetSumOddNumbers(this IEnumerable<int> sourse,out int sum)
        {
            sum = 0;
            bool hasElements = false;
            foreach (var item in sourse)
            {
                if (item%2!=0)
                {
                    sum += item;
                    hasElements = true;
                }

            }
            return hasElements;
        }
        public static bool GetIndex(this List<int> sourse, out int index)
        {
            index = 0;
            bool hasElements = false;
            for (int i = 0; i < sourse.Count; i++)
            {
                if (i%2!=0)
                {
                    index = i;

                }
                else
                {
                    break;
                }
            }
            return hasElements;
        }
        public static bool GetSumOddindex(this List<int> sourse, out int sum)
        {
            sum = 0;
            bool hasElements = false;
            if (sourse != null && sourse.Any())
            {
                for (int i = 0; i < sourse.Count; i++)
                {
                    sum += sourse[i];
                }
                hasElements = true;
            }
                
            return hasElements;

        }
    }
}
