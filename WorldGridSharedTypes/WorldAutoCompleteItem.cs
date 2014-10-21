namespace WorldGridSharedTypes
{
    using SharedTypes;
    using System;
    using System.Collections.Generic;

    public class WorldAutoCompleteItem
    {
        public HashSet<GridItemPos> atomPos;
        public HashSet<GridItemPos> openPos;
        public int size;
        public TerrainType terrain;
    }
}

