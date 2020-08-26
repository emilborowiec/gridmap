using PonderingProgrammer.GridMath;

namespace PonderingProgrammer.GridMap
{
    public class GridMap : IGridMap
    {
        public GridMap(int width, int height)
        {
            Bounds = GridBoundingBox.FromSize(0, 0, width, height);
        }

        public GridBoundingBox Bounds { get; }
    }
}