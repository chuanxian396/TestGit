namespace WorldGridLogic
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public abstract class GridContainerBase
    {
        protected static readonly IEqualityComparer<GridClasterPos> ClasterComparer;
        private static int DEFAULT_GRID_CLASTER_SIZE;
        protected readonly int GRID_CLASTER_SIZE;
        protected GridClasterPos m_gridClasterCursor;

        public GridContainerBase()
        {
        }

        public GridContainerBase(int gridClasterSize)
        {
        }

        public long Count
        {
            [CompilerGenerated]
            get
            {
            }
            [CompilerGenerated]
            protected set
            {
            }
        }

        public bool IsEmpty
        {
            get
            {
            }
        }

        private class GridClasterComparer : IEqualityComparer<GridContainerBase.GridClasterPos>
        {
            public bool Equals(GridContainerBase.GridClasterPos x, GridContainerBase.GridClasterPos y)
            {
            }

            public int GetHashCode(GridContainerBase.GridClasterPos obj)
            {
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        protected struct GridClasterPos
        {
            private const int STRIDE_SIZE_FOR_HASH = 0x200;
            private const int STRIDE_SIZE_FOR_SEGMENT = 4;
            private int x;
            private int y;
            private GridContainerBase.GridClasterSegment m_segment;
            public GridContainerBase.GridClasterSegment Segment
            {
                get
                {
                }
            }
            public bool MoveTo(int worldPosX, int worldPosY, int gridClasterSize)
            {
            }

            public override int GetHashCode()
            {
            }

            public override bool Equals(object obj)
            {
            }

            public bool Equals(GridContainerBase.GridClasterPos other)
            {
            }

            public static bool operator ==(GridContainerBase.GridClasterPos lhs, GridContainerBase.GridClasterPos rhs)
            {
            }

            public static bool operator !=(GridContainerBase.GridClasterPos lhs, GridContainerBase.GridClasterPos rhs)
            {
            }
        }

        protected enum GridClasterSegment
        {
            XY_POSITIVE,
            XY_NEGATIVE,
            XX_POSITIVE,
            YY_POSITIVE
        }
    }
}

