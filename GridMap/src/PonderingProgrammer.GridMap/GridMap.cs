using System.Collections.Generic;
using System.Linq;
using PonderingProgrammer.GridMath;

namespace PonderingProgrammer.GridMap
{
    public class GridMap : IGridMap
    {
        private List<IMapArea> _areas = new List<IMapArea>();
        
        public GridMap(int width, int height)
        {
            Bounds = GridBoundingBox.FromSize(0, 0, width, height);
        }

        public GridBoundingBox Bounds { get; }
        public IReadOnlyList<IMapArea> Areas => _areas.AsReadOnly();
        public bool AddArea(IMapArea area)
        {
            if (_areas.Any(a => a.Shape.Overlaps(area.Shape.BoundingBox))) return false;
            _areas.Add(area);
            return true;
        }
    }
}