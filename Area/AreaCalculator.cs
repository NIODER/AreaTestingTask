using Area.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public static class AreaCalculator
    {
        public static IAreaCalculatableCreator GetAreaCalculatableCreator(string creatorName)
        {
            return creatorName switch
            {
                "circle" => new CircleCreator(),
                "triangle" => new TriangleCreator(),
                _ => throw new ArgumentOutOfRangeException(nameof(creatorName))
            };
        }
    }
}
