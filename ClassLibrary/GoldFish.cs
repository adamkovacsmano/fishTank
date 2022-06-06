﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GoldFish : Fish
    {
        public GoldFish(string _name)
        {
            Name = _name;
            FoodRequiredInGrams = 0.1;
        }
    }
}