using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area.Figures
{
    public class Triangle : IAreaCalculatable
    {
        public double ASide { get; private set; }
        public double BSide { get; private set; }
        public double CSide { get; private set; }
        private readonly double hPerimeter;

        public Triangle(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
            hPerimeter = (aSide + bSide + cSide) / 2;
        }

        public bool IsRight()
        {
            var sides = new List<double>() { ASide, BSide, CSide };
            sides.Sort();
            return Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);
        }

        public double CalculateArea()
        {
            return Math.Sqrt(hPerimeter * (hPerimeter - ASide) * (hPerimeter - BSide) * (hPerimeter - CSide));
        }
    }
}
