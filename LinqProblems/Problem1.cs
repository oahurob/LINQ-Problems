using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    public class Problem1
    {
        public List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        
        public List<string> GetWordsWithTH()
        {
            
            var thWords = words.Where(w => w.Contains("th")).ToList();
            foreach(string word in thWords)
            {
                Console.WriteLine(word);
            }
            return thWords;
        }
    }
}
