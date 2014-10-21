namespace WorldGridLogic
{
    using SharedTypes;
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine;
    using WorldGridSharedTypes;

    public class WorldBlock : IGridItem
    {
        public WorldBlock(TerrainType p00, TerrainType p01, TerrainType p10, TerrainType p11)
        {
        }

        public WorldBlock Clone()
        {
        }

        public void Rotate(BlockRotationType rotation)
        {
        }

        public WorldBlock adjacentDown
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

        public WorldBlock adjacentLeft
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

        public WorldBlock adjacentRight
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

        public WorldBlock adjacentUp
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

        public bool createInactive
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

        public int Height
        {
            get
            {
            }
        }

        public bool IsActive
        {
            get
            {
            }
        }

        public bool IsAttached
        {
            get
            {
            }
        }

        public bool IsEmpty
        {
            get
            {
            }
        }

        public bool IsFull
        {
            get
            {
            }
        }

        public GridItemType ItemType
        {
            get
            {
            }
        }

        public GameObject mono
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

        public WorldBlockPart p00
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

        public WorldBlockPart p01
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

        public WorldBlockPart p10
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

        public WorldBlockPart p11
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

        public int Width
        {
            get
            {
            }
        }
    }
}

