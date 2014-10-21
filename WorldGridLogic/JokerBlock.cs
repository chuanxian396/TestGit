namespace WorldGridLogic
{
    using System;
    using System.Runtime.CompilerServices;
    using WorldGridSharedTypes;

    public class JokerBlock : IGridItem
    {
        public JokerBlock()
        {
        }

        public JokerBlock(int width, int height)
        {
        }

        public bool Generate(GridItemPos pos)
        {
        }

        public bool Generate(int x, int y)
        {
        }

        public int Height
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

        public bool IsGenerated
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

        public JokerType Type
        {
            get
            {
            }
        }

        public int Width
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

        public WorldGridLogic.WorldBlock WorldBlock
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

