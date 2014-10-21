namespace WorldGridLogic
{
    using SharedTypes;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using UnityEngine;
    using WorldGridSharedTypes;

    public class GridZoneManager
    {
        private static readonly Dictionary<WorldBlockPartType, GridItemPos> BlockPartOffsets;
        private List<GridZone> m_completedZonesAfterLastAdd;
        private WorldGridSharedTypes.EventSystem m_events;
        private GridContainer<WorldBlockPart> m_grid;
        private HashSet<GridItemPos> m_posToUpdateMaterial;
        private SortedDictionary<int, GridZone> m_zones;
        private bool m_zonesAreClosable;
        public const int RESERVED_BLOCK_PART_INDEX = -100;
        private const WorldBlockPart RESERVED_BLOCK_PART_VALUE = null;

        public void Add(GridItemPos pos, WorldBlock worldBlock, AddGridItemCause cause)
        {
        }

        public void Add(int worldGridX, int worldGridY, WorldBlock worldBlock, AddGridItemCause cause)
        {
        }

        private void AddWorldBlockPart(int x, int y, WorldBlockPartType partType, WorldBlockPart blockPart)
        {
        }

        public GridZone AddZone(TerrainType terrain)
        {
        }

        public bool CanAddToPos(GridItemPos pos, WorldBlock worldBlock)
        {
        }

        public bool CanAddToPos(int worldGridX, int worldGridY, WorldBlock worldBlock)
        {
        }

        public GridZoneManager Clone()
        {
        }

        public bool DoesZoneExist(int zoneId)
        {
        }

        public List<int> GetAdjacentZonesOfTheSameTerrain(int zoneId)
        {
        }

        public Vector3 GetAreaCenter(IEnumerable<int> zoneIds)
        {
        }

        public float GetAreaRadius(IEnumerable<int> zoneIds)
        {
        }

        public WorldBlock GetBlockAt(int worldGridX, int worldGridY)
        {
        }

        public WorldBlockPart GetBlockPartAtAtomPos(int atomPosX, int atomPosY)
        {
        }

        private WorldBlockPartType GetBlockPartType(int x, int y)
        {
        }

        private List<int> GetCompletedZoneIds()
        {
        }

        public int GetCount()
        {
        }

        public int GetCount(ZoneStatus zoneType)
        {
        }

        private int GetNextIndex()
        {
        }

        public Dictionary<GridItemPos, HashSet<int>> GetOneStepToCloseZonePos()
        {
        }

        private List<WorldBlockPart> GetPartsAround(int x, int y)
        {
        }

        private List<int> GetUncompletedZoneIds()
        {
        }

        public HashSet<GridItemPos> GetZoneAtomPositions(int zoneId)
        {
        }

        private int GetZoneIdForBlock(int x, int y, WorldBlockPartType partType, TerrainType terrain)
        {
        }

        public List<int> GetZoneIds(SearchZoneIdParam parameter, int matchValue)
        {
        }

        private List<int> GetZoneIdsToAttach(int x, int y, WorldBlockPartType partType, TerrainType xyTerrain)
        {
        }

        public HashSet<GridItemPos> GetZoneOpenPos(int zoneId)
        {
        }

        public int GetZoneOpenPosCount(int zoneId)
        {
        }

        public HashSet<GridItemPos> GetZonePositions(int zoneId)
        {
        }

        public float GetZoneRadius(int zoneId)
        {
        }

        public Material GetZoneSharedMaterial(int zoneId)
        {
        }

        public int GetZoneSize(int zoneId)
        {
        }

        public TerrainType GetZoneTerrain(int zoneId)
        {
        }

        private bool IsClosable()
        {
        }

        private bool IsVaildTerrainForPos(int x, int y, TerrainType terrain)
        {
        }

        public bool IsZoneCompleted(int zoneId)
        {
        }

        private void OnZoneComplete(GridZone zone)
        {
        }

        public void Remove(GridItemPos pos)
        {
        }

        public void Remove(int worldGridX, int worldGridY)
        {
        }

        private int RemoveWorldBlockPart(int x, int y, WorldBlockPartType partType)
        {
        }

        public void SetClosable(bool isClosable)
        {
        }

        public void SetClosable(int zoneId, bool isClosable)
        {
        }

        public void Shutdown()
        {
        }

        private void UpdateZones(AddGridItemCause cause)
        {
        }

        public IEventSystem EventSystem
        {
            get
            {
            }
        }

        [CompilerGenerated]
        private sealed class <GetAdjacentZonesOfTheSameTerrain>c__AnonStorey157
        {
            internal GridZoneManager <>f__this;
            internal List<int> list;
            internal TerrainType terrain;

            internal void <>m__24D(List<int> zones, int x, int y)
            {
            }
        }

        private enum WorldBlockPartType
        {
            TOP_LEFT,
            TOP_RIGHT,
            BOTTOM_LEFT,
            BOTTOM_RIGHT
        }
    }
}

