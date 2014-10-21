namespace WorldGridLogic
{
    using SharedTypes;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using WorldGridSharedTypes;

    public class GridPatternManager
    {
        private GridContainer<PatternBlockPart> m_grid;
        private HashSet<TerrainType> terrainsToUse;
        private Dictionary<TerrainType, List<TerrainType>> typesOtherThenKey;

        public GridPatternManager(HashSet<TerrainType> terrainsToUse)
        {
        }

        public void Add(int worldGridX, int worldGridY, PatternBlock block)
        {
        }

        private void AddBlockPart(int x, int y, PatternBlockPart part)
        {
        }

        private bool CheckAgainsPatternPart(int x, int y, TerrainType terrain)
        {
        }

        public bool CheckAgainstPattern(int worldGridX, int worldGridY, WorldBlock worldBlock)
        {
        }

        public bool FillInFromPattern(int worldGridX, int worldGridY, WorldBlock worldBlock)
        {
        }

        private bool FillInPartFromPattern(int x, int y, WorldBlockPart part)
        {
        }

        public class PatternBlockPart
        {
            public PatternBlockPart(TerrainType terrain, PartType type)
            {
            }

            public TerrainType Terrain
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

            public PartType Type
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

            public enum PartType
            {
                HasToMatch,
                AnythingExceptFor
            }
        }
    }
}

