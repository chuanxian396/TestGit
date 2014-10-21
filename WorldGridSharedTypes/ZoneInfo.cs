namespace WorldGridSharedTypes
{
    using SharedTypes;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class ZoneInfo
    {
        private List<GridItemPos> m_powerPoints;

        public ZoneInfo(int id, TerrainType terrain, int size, int openPos, bool completed, List<GridItemPos> powerPoints)
        {
        }

        public ZoneInfo Clone()
        {
        }

        public bool Completed
        {
            [CompilerGenerated]
            get
            {
            }
            [CompilerGenerated]
            private set
            {
            }
        }

        public int Id
        {
            [CompilerGenerated]
            get
            {
            }
            [CompilerGenerated]
            private set
            {
            }
        }

        public int OpenPos
        {
            [CompilerGenerated]
            get
            {
            }
            [CompilerGenerated]
            private set
            {
            }
        }

        public IList<GridItemPos> PowerPoints
        {
            get
            {
            }
        }

        public int Size
        {
            [CompilerGenerated]
            get
            {
            }
            [CompilerGenerated]
            private set
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
            private set
            {
            }
        }

        public string TerrainDesc
        {
            get
            {
            }
        }
    }
}

