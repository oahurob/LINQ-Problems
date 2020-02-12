using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Problem4
    {
        string lettersToTest = "terrill";

        public void NumberOfLetters()
        {
            var letterNumbers = string.Join("", lettersToTest.OrderBy(c => c).Distinct().Select(x => $"{x}{lettersToTest.Count(y => y == x)}")).ToUpper();
            foreach(var l in letterNumbers)
            {
                Console.Write(l + " ");
            }
        }


    }
}
