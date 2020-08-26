using System.Collections.Generic;
using PonderingProgrammer.GridMath;

namespace PonderingProgrammer.GridMap
{
    public interface IGridMap
    {
        GridBoundingBox Bounds { get; }
        IReadOnlyList<IMapArea> Areas { get; }
        bool AddArea(IMapArea area);
    }
}