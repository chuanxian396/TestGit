namespace WorldGridSharedTypes
{
    using System;

    public interface IGridItem
    {
        int Height { get; }

        GridItemType ItemType { get; }

        int Width { get; }
    }
}

