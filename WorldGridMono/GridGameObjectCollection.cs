namespace WorldGridMono
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using UnityEngine;
    using WorldGridSharedTypes;

    public class GridGameObjectCollection
    {
        private Dictionary<GridItemPos, GameObject> m_gameObjects;
        private GameObject m_parent;
        private readonly string PARENT_NAME;

        public GridGameObjectCollection(string parentName)
        {
        }

        public bool Add(int x, int y, GameObject block, float worldSpaceUpDownPos)
        {
        }

        public void Clear(bool usePooling = false)
        {
        }

        public bool Contains(GridItemPos gridPos)
        {
        }

        private void EnsureParentExist()
        {
        }

        public GameObject GetAt(GridItemPos pos)
        {
        }

        public GameObject GetParent()
        {
        }

        public bool IsGameObjectNull(GridItemPos gridPos)
        {
        }

        public void RemoveAt(GridItemPos pos)
        {
        }

        public void RemoveAt(int x, int y, bool usePooling = false)
        {
        }

        private bool IsParentNameVaild
        {
            get
            {
            }
        }
    }
}

