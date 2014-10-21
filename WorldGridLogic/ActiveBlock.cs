namespace WorldGridLogic
{
    using System;
    using System.Collections.Generic;
    using WorldGridSharedTypes;

    public class ActiveBlock
    {
        private const int DEFAULT_QUEUE_SIZE = 10;
        private LinkedList<IGridItem> m_blocksQueue;
        private WorldGridSharedTypes.EventSystem m_events;
        private const int MAX_QUEUE_SIZE = 200;
        private const int MIN_QUEUE_SIZE = 2;
        public readonly int QueueSize;

        public ActiveBlock()
        {
        }

        public ActiveBlock(int maxQueueSize)
        {
        }

        public bool Add(QueueAddType addAt, IGridItem item)
        {
        }

        private bool AddFirst(IGridItem item)
        {
        }

        private bool AddLast(IGridItem item)
        {
        }

        public void Clear()
        {
        }

        public void ClearExceptFirst()
        {
        }

        public bool Next(bool isRepick)
        {
        }

        public bool ReplaceFirst(IGridItem item)
        {
        }

        public int Count
        {
            get
            {
            }
        }

        public IEventSystem EventSystem
        {
            get
            {
            }
        }

        public bool HasValue
        {
            get
            {
            }
        }

        public IGridItem Value
        {
            get
            {
            }
        }
    }
}

