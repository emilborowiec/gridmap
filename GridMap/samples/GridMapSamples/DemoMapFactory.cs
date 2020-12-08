using GridMap;
using GridMath.Shapes;

namespace GridMapSamples
{
    public static class DemoMapFactory
    {
        public static IGridMap CreateDemoMap(int width, int height)
        {
            var map = new GridMap.SquareGridMap(width, height);
            
            var room = new Feature(new GridRectangle(0, 0, 4, 3));
            map.AddFeature(room);

            return map;
        }
    }
}