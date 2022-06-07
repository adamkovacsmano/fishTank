using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BabelFish : Fish
    {
        public static double Weight = 0.3;

        public BabelFish(string _name) : base(_name)
        {
        }

        public override double GetFoodWeight()
        {
            return Weight;
        }
    }
}