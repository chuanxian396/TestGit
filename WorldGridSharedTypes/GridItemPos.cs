namespace WorldGridSharedTypes
{
    using Common;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct GridItemPos : IComparer<GridItemPos>, IComparable<GridItemPos>
    {
        private const int STRIDE_SIZE_FOR_HASH = 0x200;
        public int X;
        public int Y;
        public GridItemPos(int x, int y)
        {
        }

        public static GridItemPos Right
        {
            get
            {
            }
        }
        public static GridItemPos Left
        {
            get
            {
            }
        }
        public static GridItemPos Up
        {
            get
            {
            }
        }
        public static GridItemPos Down
        {
            get
            {
            }
        }
        public override int GetHashCode()
        {
        }

        public override bool Equals(object obj)
        {
        }

        public bool Equals(GridItemPos other)
        {
        }

        public override string ToString()
        {
        }

        public int Compare(GridItemPos lhs, GridItemPos rhs)
        {
        }

        public int CompareTo(GridItemPos other)
        {
        }

        public static GridItemPos operator *(GridItemPos pos, float s)
        {
        }

        public static GridItemPos operator +(GridItemPos pos, Vector2_int v)
        {
        }

        public static GridItemPos operator -(GridItemPos pos, Vector2_int v)
        {
        }

        public static GridItemPos operator +(GridItemPos pos1, GridItemPos pos2)
        {
        }

        public static GridItemPos operator -(GridItemPos pos1, GridItemPos pos2)
        {
        }

        public static bool operator ==(GridItemPos lhs, GridItemPos rhs)
        {
        }

        public static bool operator !=(GridItemPos lhs, GridItemPos rhs)
        {
        }

        public static explicit operator Vector2_int(GridItemPos pos)
        {
        }

        public static explicit operator GridItemPos(Vector2_int v)
        {
        }
    }
}

