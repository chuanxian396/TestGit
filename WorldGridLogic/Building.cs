namespace WorldGridLogic
{
    using System;
    using System.Runtime.CompilerServices;
    using WorldGridSharedTypes;

    public class Building : IGridItem
    {
        private static readonly int HOUSE_COUNT;

        public Building()
        {
        }

        public Building(int buildingId)
        {
        }

        public int BuildingId
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

        public int Height
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

        public int Width
        {
            get
            {
            }
        }
    }
}

