using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list = new List<string>() { "kakLja", "kayEla", "kauVoa", "kahOna", "kajNjjah" };
            for (int i = 0; i < list.Count; i++)
            {
                list[i].GetCharElement(out char result);
                Console.Write(result);
            }
            Console.WriteLine();
            List<int> list1 = new List<int>() ;
            Random rnd = new Random();
            for (int i = 0; i <21; i++)
            {
                list1.Add(rnd.Next(2, 2500));
            }
            list1.GetSumOddNumbers(out int sum);
            Console.WriteLine(sum);
            
            
        }
    }
}
