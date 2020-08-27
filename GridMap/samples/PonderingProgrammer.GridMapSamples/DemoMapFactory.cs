using PonderingProgrammer.GridMap;
using PonderingProgrammer.GridMath.Shapes;

namespace PonderingProgrammer.GridMapSamples
{
    public static class DemoMapFactory
    {
        public static IGridMap CreateDemoMap(int width, int height)
        {
            var map = new GridMap.SquareGridMap(width, height);
            
            var room = new MapArea(new GridRectangle(0, 0, 4, 3));
            map.AddArea(room);

            return map;
        }
    }
}