namespace WorldGridLogic
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class GridContainer<T> : GridContainerBase where T: class
    {
        private T[,] m_currClaster;
        private Dictionary<GridContainerBase.GridClasterPos, object[,]> m_grid;

        public GridContainer()
        {
        }

        public GridContainer(int gridClasterSize)
        {
        }

        public bool Add(int x, int y, T item)
        {
        }

        private void AddItemToClaster(T[,] gridClaster, int worldPosX, int worldPosY, GridContainerBase.GridClasterSegment segment, T item)
        {
        }

        private void EnsureGridClasterExist(GridContainerBase.GridClasterPos pos)
        {
        }

        public T GetAt(int x, int y)
        {
        }

        private T[,] GetGridClaster(GridContainerBase.GridClasterPos pos)
        {
        }

        private T GetItemFromClaster(T[,] gridClaster, int worldPosX, int worldPosY, GridContainerBase.GridClasterSegment segment)
        {
        }

        public bool HasValue(int x, int y)
        {
        }

        private bool IsClasterExist(GridContainerBase.GridClasterPos pos)
        {
        }

        public void RemoveAt(int x, int y)
        {
        }

        public void Replace(int x, int y, T item)
        {
        }

        public T this[int x, int y]
        {
            get
            {
            }
        }
    }
}

