using PonderingProgrammer.GridMath.Shapes;

namespace PonderingProgrammer.GridMap
{
    public class MapArea : IMapArea
    {
        public MapArea(IGridShape shape)
        {
            Shape = shape;
        }

        public IGridShape Shape { get; }
    }
}