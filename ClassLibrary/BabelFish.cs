using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BabelFish : Fish
    {
        public BabelFish(string _name)
        {
            Name = _name;
            FoodRequiredInGrams = 0.3;
        }
    }
}