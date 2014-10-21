namespace WorldGridLogic
{
    using SharedTypes;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Runtime.InteropServices;
    using WorldGridSharedTypes;

    public class WorldBlockGenerator
    {
        private static readonly int CLOSING_POS_INDEX;
        public static string DebugLog;
        private List<int> localVar_notEmptyBaskets;
        private Dictionary<int, List<GridItemPos>> m_availableByNeighbors;
        private LinkedList<WorldBlock> m_prevBlockQueue;
        private LinkedList<GridItemPos> m_prevPosQueue;
        private WeightedRandomizer<int> m_randomizer;
        private List<TerrainType> m_terrainToUse;

        public WorldBlockGenerator(HashSet<TerrainType> terrainsToUse)
        {
        }

        public void AddBlockAsUsed(WorldBlock worldBlock)
        {
        }

        private void GenerateWorldBlock(Func<int, int, WorldBlock> getBlockAt, ref GridItemPos pos, ref WorldBlock block)
        {
        }

        public WorldBlock GenerateWorldBlock(Dictionary<GridItemPos, PosAround> availablePos, Dictionary<GridItemPos, HashSet<int>> oneStepToCloseZone, GenerationCause reason, Func<int, int, WorldBlock> getBlockAt)
        {
        }

        private int GetFlagCount(PosAround posAround)
        {
        }

        public Dictionary<GridItemPos, double> GetPositionsToRate()
        {
        }

        private TerrainType GetRandomTerrain(List<TerrainType> terrains = null)
        {
        }

        private float GetRateByIndex(int index)
        {
        }

        public void SetGeneratorData(Dictionary<GridItemPos, PosAround> positions, Dictionary<GridItemPos, HashSet<int>> oneStepToClosePos)
        {
        }

        public bool TryToCompleteBlock(WorldBlock worldBlock, out WorldBlock completedBlock, List<TerrainType> terrains = null)
        {
        }

        public ReadOnlyCollection<TerrainType> TerrainsToUse
        {
            get
            {
            }
        }

        public enum GenerationCause
        {
            NextBlock,
            Recycle
        }
    }
}

