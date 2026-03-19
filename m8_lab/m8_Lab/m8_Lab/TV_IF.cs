using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m8_Lab
{
    internal interface TV_IF
    {
        TV Replenish(string type, int budget);
        string GetType();
        string GetInfo();
        string GetBrand();
    }
}
