namespace WorldGridLogic
{
    using SharedTypes;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using UnityEngine;
    using WorldGridSharedTypes;

    public class GridZone : IDisposable
    {
        private HashSet<GridItemPos> localvar_worldPositions;
        private Dictionary<GridItemPos, WorldBlockPart> m_parts;
        private Material m_sharedMaterial;

        private GridZone(TerrainType terrain, int id)
        {
        }

        public bool Add(GridItemPos gridItemPos, WorldBlockPart worldBlockPart)
        {
        }

        public bool AddZone(GridZone zone)
        {
        }

        public bool ChangeTerrain(TerrainType terrain)
        {
        }

        public GridZone Clone()
        {
        }

        public static GridZone Create(TerrainType terrain, int index)
        {
        }

        public void Dispose()
        {
        }

        public HashSet<GridItemPos> GetAtomPositions()
        {
        }

        private ZonePosType GetAtomPosType(GridItemPos atomPos)
        {
        }

        public Vector3 GetCenter()
        {
        }

        public HashSet<GridItemPos> GetClosedWorldPositons()
        {
        }

        private ZonePosType GetGridPosTypeByAtomPos(GridItemPos atomPos)
        {
        }

        public float GetMaxDistance(Vector3 point)
        {
        }

        public HashSet<GridItemPos> GetOpenWorldPositons()
        {
        }

        public HashSet<GridItemPos> GetReservedAtomPositions()
        {
        }

        public HashSet<GridItemPos> GetWorldPositons()
        {
        }

        public bool Remove(GridItemPos gridItemPos)
        {
        }

        private void SetAllPartsActive(bool isActive)
        {
        }

        public List<GridZone> SplitIntoZones(GridZoneManager manager)
        {
        }

        public void UpdateZoneStatus()
        {
        }

        public static GridItemPos ZoneGridPosToWorldGridPos(GridItemPos zoneGridPos)
        {
        }

        public int AtomSize
        {
            get
            {
            }
        }

        public int ClosedGridPosCount
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

        public int GridSize
        {
            get
            {
            }
        }

        public int Id
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

        public bool IsClosable
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

        public bool IsCompleted
        {
            get
            {
            }
        }

        public CallbackFn OnBackInactive
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

        public CallbackFn OnComplete
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

        public int OpenAtomPosCount
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

        public int OpenGridPosCount
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

        public Dictionary<GridItemPos, WorldBlockPart> Parts
        {
            get
            {
            }
        }

        public Material sharedMaterial
        {
            get
            {
            }
        }

        public ZoneStatus Status
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

        public TerrainType Terrain
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

        public delegate void CallbackFn(GridZone zone);
    }
}

