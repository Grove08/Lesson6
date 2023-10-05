using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = "";
            string str3 = str.Replace(" ", "").ToLower();
            foreach (char c in str3) 
            {
                str2 = c + str2;

            }
            if (str2== str3) 
            {
                Console.WriteLine("Введенная строка является палиндромом.");
            }
            else
            {
                Console.WriteLine("Введенная строка не является палиндромом.");
            }
            
            Console.ReadKey();
        }
    }
}
