using Area.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateAreaTest()
        {
            var circle = new Circle(10);
            Assert.Equal(314.15926535898, Math.Round(circle.CalculateArea(), 11));
        }
    }
}
