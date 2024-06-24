using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACALessons
{
    internal class Program
    {
        public static void addition(int a, int b)
        {
            int sum = a * b;
        }
        
        public static int Sum(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            addition(10,20);
            Console.ReadLine(); 
        }
    }
}
