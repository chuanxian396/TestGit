namespace WorldGridMono
{
    using SharedTypes;
    using System;
    using System.Collections.Generic;
    using UnityEngine;
    using WorldGridSharedTypes;

    public class GridManagerMono
    {
        public const float BLOCK_HEIGHT = 2f;
        public const float BLOCK_WIDTH = 2f;
        private AvailablePosInfo m_availablePositions;
        private Dictionary<GridItemPos, GameObject> m_gridAvailablePosObjects;
        private Dictionary<GridItemPos, GameObject> m_gridObjects;
        private bool m_isAvailablePosVisible;
        private GameObject m_parent;
        private const string PARENT_NAME = "WorldGrid";
        private const float WORLD_POS_Y = -0.2f;

        public bool Add(int x, int y, IGridItem item, GameObject block)
        {
        }

        private bool AddAvailablePos(GridItemPos gridPos, GameObject block)
        {
        }

        public void Clear()
        {
        }

        private void CreateParent()
        {
        }

        public GameObject GetAt(int x, int y)
        {
        }

        public GameObject GetAvailablePosAt(int x, int y)
        {
        }

        public Vector3 GetCenterOfGrid()
        {
        }

        public GameObject GetParent()
        {
        }

        public static Vector3 GetPosUnderCursor()
        {
        }

        public static Vector3 GetPosUnderScreenPoint(Vector2 scrPoint)
        {
        }

        public static Vector3 GridPosToWorldPos(GridItemPos gridPos)
        {
        }

        public static Vector3 GridPosToWorldPos(int x, int y)
        {
        }

        private bool PlaceOnGrid(GridItemPos gridPos, GameObject block, int width, int height, float worldPosY)
        {
        }

        public void PlayEarthQk(IEnumerable<GridItemPos> list)
        {
        }

        public void RemoveAt(int x, int y)
        {
        }

        private void RemoveAvailablePosAt(int x, int y)
        {
        }

        private void RemoveObjectFromGrid(GridItemPos gridPos, Dictionary<GridItemPos, GameObject> collection)
        {
        }

        private void SetActive(bool isActive)
        {
        }

        public void SetActive(bool isActive, GridItemPos pos)
        {
        }

        public static Vector3 SmallGridPosToWorldPos(GridItemPos gridPos)
        {
        }

        public static void TryDestroyOrReturnToPool(GameObject go)
        {
        }

        public void UpdateAvailablePositions(SettingType settingType, AvailablePosInfo availablePosInfo)
        {
        }

        public static GridItemPos WorldPosToGridPos(Vector3 worldPos)
        {
        }

        public static GridItemPos WorldPosToSmallGridPos(Vector3 worldPos)
        {
        }

        public bool AvailablePosVisible
        {
            get
            {
            }
            set
            {
            }
        }

        public static string WorldGridName
        {
            get
            {
            }
        }
    }
}

