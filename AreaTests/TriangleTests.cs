using Area.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea());
            triangle = new Triangle(10, 10, 10);
            Assert.Equal(43.301270189222, Math.Round(triangle.CalculateArea(), 12));
        }

        [Fact]
        public void IsRightTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRight());
            triangle = new Triangle(10, 10, 10);
            Assert.False(triangle.IsRight());
        }
    }
}
