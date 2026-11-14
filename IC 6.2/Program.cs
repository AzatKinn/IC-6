using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string str1 = "";
            string str2 = "";
            foreach (string s in strArray)
            {
                str1 += s.Substring(0,1).ToLower()+s.Substring(1).Replace(" ","");
            }
            foreach (char c in str1)
            {
                str2 = c + str2;
            }
            if (str1 == str2)
                Console.WriteLine("Является");
            else
                Console.WriteLine("Не является");
            Console.ReadKey();
        }
    }
}
