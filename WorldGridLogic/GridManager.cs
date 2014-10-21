namespace WorldGridLogic
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using WorldGridSharedTypes;

    public class GridManager
    {
        private HashSet<GridItemPos> m_activeAvailablePositions;
        private bool m_activePositionsVisible;
        private HashSet<GridItemPos> m_availablePositions;
        private Dictionary<GridItemPos, PosAround> m_availablePosNeighbours;
        private HashSet<GridItemPos> m_detachedPositions;
        private GridContainer<IGridItem> m_grid;
        private Dictionary<GridItemPos, IGridItem> m_gridBlockedPositions;
        private Dictionary<GridItemType, List<GridItemPos>> m_gridItemsByType;
        private Dictionary<GridItemType, List<GridItemPos>> m_gridPosBlockedByType;
        private HashSet<GridItemPos> m_lastValidActiveAvailable;
        private Dictionary<GridItemPos, PosAround> m_nearPattern;
        private Dictionary<GridItemPos, PosAround> m_notAvailablePosNearWorld;
        private static readonly HashSet<GridItemType> m_spawnAvailablePosTypes;

        public bool Add(int x, int y, IGridItem item)
        {
        }

        private void AddAvailablePos(int blockX, int blockY, GridItemType itemType, PosAround availablePos)
        {
        }

        private void AddAvailablePosAround(int x, int y, GridItemType itemType)
        {
        }

        public void AddDetachedPos(GridItemPos pos, GridItemType itemType)
        {
        }

        public void AddDetachedPos(int x, int y, GridItemType itemType)
        {
        }

        public bool AddForce(int x, int y, IGridItem item)
        {
        }

        public bool CanPlaceItem(GridItemPos pos, IGridItem item)
        {
        }

        public bool CanPlaceItem(int x, int y, IGridItem item)
        {
        }

        private void DecrCounter(int x, int y, GridItemType gridItemType)
        {
        }

        private void EnsureGridItemsContainsType(GridItemType gridItemType)
        {
        }

        public IGridItem GetAt(int x, int y)
        {
        }

        public ReadOnlyCollection<GridItemPos> GetBlockedPositions(GridItemType itemType)
        {
        }

        public IGridItem GetBlockingItem(GridItemPos pos)
        {
        }

        public IGridItem GetBlockingItem(int x, int y)
        {
        }

        public GridItemType GetBlockingType(GridItemPos pos)
        {
        }

        public GridItemType GetBlockingType(int x, int y)
        {
        }

        public int GetCount()
        {
        }

        public int GetCount(GridItemType gridItemType)
        {
        }

        public int GetDetachedPositionsCount()
        {
        }

        public ReadOnlyCollection<GridItemPos> GetGridItemPositions(GridItemType itemType)
        {
        }

        public GridItemPos GetItemPosForBlockedPos(GridItemPos pos)
        {
        }

        public bool HasValue(GridItemPos pos)
        {
        }

        public bool HasValue(int x, int y)
        {
        }

        private void IncrCounter(int x, int y, GridItemType gridItemType)
        {
        }

        public bool IsBlocked(GridItemPos pos)
        {
        }

        public bool IsBlocked(int x, int y)
        {
        }

        public bool IsDetachedPosition(GridItemPos pos)
        {
        }

        public bool IsDetachedPosition(int x, int y)
        {
        }

        public bool IsPosAvailable(int x, int y, GridItemType itemType)
        {
        }

        private bool IsSpawnAvailablePosType(GridItemType itemType)
        {
        }

        public void OnDrawGizmos()
        {
        }

        public void OnPositionAttachedOrRemoved(GridItemPos pos, GridItemType itemType)
        {
        }

        public void OnPositionAttachedOrRemoved(int x, int y, GridItemType itemType)
        {
        }

        public void RemoveAt(int x, int y)
        {
        }

        private void RemoveAvailablePos(int blockX, int blockY, GridItemType itemType, PosAround availablePos)
        {
        }

        private void RemoveAvailablePosAround(int x, int y, GridItemType itemType)
        {
        }

        private void RemoveAvailablePosAt(int x, int y, GridItemType itemType)
        {
        }

        private void RestoreAvailablePos(int x, int y, PosAround posAround)
        {
        }

        private void RestoreAvailablePosAround(int x, int y)
        {
        }

        public void SetActiveAvailablePositions(HashSet<GridItemPos> positions)
        {
        }

        private void UpdateActiveAvailablePositions(HashSet<GridItemPos> positions)
        {
        }

        public HashSet<GridItemPos> ActiveAvailablePositions
        {
            get
            {
            }
        }

        public bool ActivePositionsVisible
        {
            get
            {
            }
            set
            {
            }
        }

        public HashSet<GridItemPos> AvailablePositions
        {
            get
            {
            }
        }

        public Dictionary<GridItemPos, PosAround> AvailablePosNeighbours
        {
            get
            {
            }
        }

        public ReadOnlyCollection<GridItemPos> DetachedPositions
        {
            get
            {
            }
        }

        public bool IsEmpty
        {
            get
            {
            }
        }

        public Dictionary<GridItemPos, PosAround> NotAvailableNearWorld
        {
            get
            {
            }
        }

        public Dictionary<GridItemPos, PosAround> PositionsNearWorld
        {
            get
            {
            }
        }
    }
}

