//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Circle
{
    class Circle : Area
    {
        public double Area(double Pi, double Radius)
        {
            return Pi * Math.Pow(Radius, 2);
        }
    }
}
