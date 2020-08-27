using PonderingProgrammer.GridMath;
using PonderingProgrammer.GridMath.Shapes;
using QuickGraph;

namespace PonderingProgrammer.GridMap
{
    public interface IMapArea
    {
        IGridShape Shape { get; }
        AdjacencyGraph<SquareMapField, Edge<SquareMapField>> FieldGraph { get; }
        bool HasFieldAt(int x, int y);
        bool HasFieldAt(GridCoordinatePair coordinates);
        SquareMapField GetFieldAt(int x, int y);
        SquareMapField GetFieldAt(GridCoordinatePair coordinates);
    }
}