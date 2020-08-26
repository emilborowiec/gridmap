using PonderingProgrammer.GridMap;

namespace PonderingProgrammer.GridMapSamples
{
    public static class DemoMapFactory
    {
        public static IGridMap CreateDemoMap(int width, int height)
        {
            var map = new GridMap.GridMap(width, height);

            return map;
        }
    }
}