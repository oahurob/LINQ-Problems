using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Problem3
    {
        public List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
        
        public void Average()
        {
            var average = classGrades.Select(s => s.Split(',').Select(int.Parse).ToList().OrderByDescending(i => i).Take(classGrades.Count).Average()).Average();
            Console.WriteLine(average);
        }
    }
}
