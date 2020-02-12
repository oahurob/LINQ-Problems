using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1 problem1 = new Problem1();
            Problem2 problem2 = new Problem2();
            Problem3 problem3 = new Problem3();
            Problem4 problem4 = new Problem4();
            problem1.GetWordsWithTH();
            Console.WriteLine();
            problem2.RemoveDup();
            Console.WriteLine();
            problem3.Average();
            Console.WriteLine();
            problem4.NumberOfLetters();
            Console.ReadLine();
        }
    }
}
