namespace WorldGridMono
{
    using SharedTypes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using WorldGridSharedTypes;

    public class BlockPartModelInfo
    {
        private WorldBlockPart m_part;

        public BlockPartModelInfo(WorldBlockPart part, BlockPartModelType modelType, BlockRotationType rotation, ShadowType shadow = 0)
        {
        }

        public override bool Equals(object obj)
        {
        }

        public bool Equals(BlockPartModelInfo other)
        {
        }

        public override int GetHashCode()
        {
        }

        public bool IsActive
        {
            get
            {
            }
        }

        public BlockPartModelType ModelType
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

        public BlockRotationType Rotation
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

        public ShadowType Shadow
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
            get
            {
            }
        }

        public bool UpdateMaterial
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
            get
            {
            }
        }

        [Flags]
        public enum ShadowType
        {
            None,
            Top,
            Right,
            TopAndRight,
            Left,
            TopAndLeft,
            Bottom,
            FarRight,
            FarTop
        }
    }
}

