using Area;
using Area.Creators;
using Area.Figures;

namespace AreaTests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void GetCreator()
        {
            Assert.IsAssignableFrom<TriangleCreator>(AreaCalculator.GetAreaCalculatableCreator("triangle"));
            Assert.IsAssignableFrom<CircleCreator>(AreaCalculator.GetAreaCalculatableCreator("circle"));
        }
    }
}