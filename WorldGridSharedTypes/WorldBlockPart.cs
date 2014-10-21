namespace WorldGridSharedTypes
{
    using SharedTypes;
    using System;
    using System.Runtime.CompilerServices;

    public class WorldBlockPart
    {
        public static readonly int INVALID_ID;

        public WorldBlockPart()
        {
        }

        public WorldBlockPart(TerrainType terrain)
        {
        }

        private WorldBlockPart(TerrainType terrain, int zoneId, bool isActive)
        {
        }

        public WorldBlockPart Clone()
        {
        }

        public bool HasTerrain
        {
            get
            {
            }
        }

        public bool IsActive
        {
            [CompilerGenerated]
            get
            {
            }
            [CompilerGenerated]
            set
            {
            }
        }

        public TerrainType Terrain
        {
            [CompilerGenerated]
            get
            {
            }
            [CompilerGenerated]
            set
            {
            }
        }

        public int ZoneId
        {
            [CompilerGenerated]
            get
            {
            }
            [CompilerGenerated]
            set
            {
            }
        }
    }
}

