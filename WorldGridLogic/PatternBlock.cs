namespace WorldGridLogic
{
    using SharedTypes;
    using System;
    using System.Runtime.CompilerServices;
    using WorldGridSharedTypes;

    public class PatternBlock : IGridItem
    {
        public PatternBlock(int patternId, TerrainType p00, TerrainType p01, TerrainType p10, TerrainType p11)
        {
        }

        public PatternBlock Clone()
        {
        }

        public void Rotate(BlockRotationType rotation)
        {
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

        public int PatternId
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

