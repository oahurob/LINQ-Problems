using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    public class Problem2
    {
        public List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

        public void RemoveDup()
        {
            var name = names.OrderBy(a => new string(a.ToCharArray().ToArray())).Distinct();
            foreach(var n in name)
            {
                Console.WriteLine(n);
            }
        }

    }
}
