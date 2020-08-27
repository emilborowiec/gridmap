using PonderingProgrammer.GridMath;

namespace PonderingProgrammer.GridMap
{
    public class SquareMapField
    {
        public SquareMapField(GridCoordinatePair coordinates, MapArea area)
        {
            Coordinates = coordinates;
            Area = area;
        }

        public GridCoordinatePair Coordinates { get; }
        public MapArea Area { get; }
    }
}