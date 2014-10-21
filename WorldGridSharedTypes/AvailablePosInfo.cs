namespace WorldGridSharedTypes
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class AvailablePosInfo
    {
        private Dictionary<GridItemPos, Property> m_properties;

        public void AddPosition(GridItemPos gridPos, HashSet<int> oneStepToCloseZones)
        {
        }

        public void AddRotationType(GridItemPos gridPos, BlockRotationType rotation, bool breaksPattern)
        {
        }

        public bool DoesBreakPatterns(GridItemPos gridPos)
        {
        }

        private Property.BlockRotation GetOptimalRotation(GridItemPos gridPos)
        {
        }

        public BlockRotationType GetRotation(GridItemPos gridPos)
        {
        }

        public bool IsOneStepToCloseZone(GridItemPos gridPos)
        {
        }

        public HashSet<GridItemPos> Positions
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

        [CompilerGenerated]
        private sealed class <AddRotationType>c__AnonStorey14E
        {
            internal BlockRotationType rotation;

            internal bool <>m__23D(AvailablePosInfo.Property.BlockRotation i)
            {
            }
        }

        private class Property
        {
            public bool IsOneStepToCloseZone
            {
                get
                {
                }
            }

            public HashSet<int> OneStepToCloseZones
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

            public List<BlockRotation> Rotations
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

            public class BlockRotation
            {
                public BlockRotation(BlockRotationType type, bool breaksPattern)
                {
                }

                public bool BreaksPattern
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

                public BlockRotationType Type
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
            }
        }
    }
}

