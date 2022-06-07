using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GoldFish : Fish
    {
        public static double Weight = 0.1;

        public GoldFish(string _name) : base(_name)
        {
        }

        public override double GetFoodWeight()
        {
            return Weight;
        }
    }
}