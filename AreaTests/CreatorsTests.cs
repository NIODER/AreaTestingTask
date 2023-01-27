using Area.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTests
{
    public class CreatorsTests
    {
        [Fact]
        public void TriangleSidesValidationTest()
        {
            var triangleCreator = new TriangleCreator(1, 1, -1);
            Assert.Throws<ArgumentException>(() => triangleCreator.CreateAreaCalculatable());
            triangleCreator = new TriangleCreator(1, 1, 0);
            Assert.Throws<ArgumentException>(() => triangleCreator.CreateAreaCalculatable());
        }

        [Fact]
        public void CircleSidesValidationTest() 
        {
            var circleCreator = new CircleCreator(-1);
            Assert.Throws<ArgumentException>(() => circleCreator.CreateAreaCalculatable());
            circleCreator = new CircleCreator(0);
            Assert.Throws<ArgumentException>(() => circleCreator.CreateAreaCalculatable());
        }
    }
}
