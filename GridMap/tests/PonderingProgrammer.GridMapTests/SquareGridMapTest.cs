using Xunit;

using PonderingProgrammer.GridMap;
using PonderingProgrammer.GridMath.Shapes;

namespace PonderingProgrammer.GridMapTests
{
    public class SquareGridMapTest
    {
        [Fact]
        public void TestAddAreas()
        {
            var map = new SquareGridMap(10, 10);
            Assert.False(map.AddArea(null));
            Assert.False(map.AddArea(new MapArea(new GridRectangle(-1, 0, 5, 5))));
            Assert.True(map.AddArea(new MapArea(new GridRectangle(0, 0, 5, 5))));
            Assert.False(map.AddArea(new MapArea(new GridRectangle(0, 0, 5, 5))));
            Assert.True(map.AddArea(new MapArea(new GridRectangle(5, 2, 2, 2))));
        }
    }
}