using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy___Activity_Selection
{
    public class Activity
    {
        public string Name { get; set; }
        public int Start { get; set; }
        public int Finish { get; set; }

        public Activity(string name, int start, int finish)
        {
            Name = name;
            Start = start;
            Finish = finish;
        }
    }
}
