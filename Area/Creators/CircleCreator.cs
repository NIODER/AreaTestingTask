using Area.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Area.Creators
{
    public class CircleCreator : IAreaCalculatableCreator
    {
        private const string NAME = "circle";

        public double Radius { get; set; }

        public CircleCreator()
        {
        }

        public CircleCreator(double radius)
        {
            Radius = radius;
        }

        public IAreaCalculatable CreateAreaCalculatable()
        {
            if (Radius <= 0)
            {
                throw new ArgumentException($"Radius should be positive number. Radius: {Radius}.");
            }
            return new Circle(Radius);
        }

        public string GetFigureName() => NAME;
    }
}
