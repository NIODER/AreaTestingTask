using Area.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area.Creators
{
    public class TriangleCreator : IAreaCalculatableCreator
    {
        private const string NAME = "triangle";

        public double ASide { get; set; }
        public double BSide { get; set; }
        public double CSide { get; set; }

        public TriangleCreator()
        {
        }

        public TriangleCreator(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public IAreaCalculatable CreateAreaCalculatable()
        {
            if (ASide > 0 && BSide > 0 && CSide > 0)
            {
                return new Triangle(ASide, BSide, CSide);
            }
            throw new ArgumentException($"One of sides is less or equal to zero. A: {ASide}, B: {BSide}, C: {CSide}.");
        }
        
        public string GetFigureName() => NAME;
    }
}
