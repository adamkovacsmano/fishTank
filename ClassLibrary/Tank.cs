using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Tank
    {
        private readonly List<Fish> _fish = new();

        public void Add(Fish fish)
        {
            _fish.Add(fish);
        }

        public double Feed()
        {
            double sum = 0;

            _fish.ForEach(f => sum += f.FoodRequiredInGrams());

            return sum;
        }
    }
}