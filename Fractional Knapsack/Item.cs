using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractional_Knapsack
{
    public class Item
    {
        public double Value { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }
        public double Ratio { get; private set; }

        // Initialize item properties and calculate density ratio safely
        public Item(double value, double weight, string name)
        {
            Value = value;
            Weight = weight;
            Name = name;
            Ratio = weight != 0 ? value / weight : 0;
        }
    }
}
