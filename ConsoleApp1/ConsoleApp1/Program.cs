using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(count("azad",'b'));
            Console.ReadLine(); 
        }
        static int count(string ad,char herf)
        {
            int a = 0;
            for (int i = 0; i < ad.Length; i++)
            {
                if (ad[i] == herf)
                {
                    a++;
                }
            }
            return a;
           
        }
    }
}
