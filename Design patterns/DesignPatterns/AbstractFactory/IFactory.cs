﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IFactory<Brand> where Brand: IBrand
    {
        IBag CreateBag();
        IShoes CreateShoes();
    }
}
