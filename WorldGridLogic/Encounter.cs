namespace WorldGridLogic
{
    using System;
    using WorldGridSharedTypes;

    public abstract class Encounter : IGridItem
    {
        protected Encounter()
        {
        }

        public abstract WorldGridSharedTypes.EncounterType EncounterType { get; }

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

