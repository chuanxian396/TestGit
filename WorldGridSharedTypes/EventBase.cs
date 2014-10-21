namespace WorldGridSharedTypes
{
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;

    public class EventBase
    {
        public EventBase(GameEventType eventType, Hashtable eventParams)
        {
        }

        public T Get<T>(object key)
        {
        }

        public Hashtable Params
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

        public GameEventType Type
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

