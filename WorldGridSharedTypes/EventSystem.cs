namespace WorldGridSharedTypes
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public sealed class EventSystem : IEventSystem
    {
        private Dictionary<GameEventType, EventListenerDelegate> m_listeners;

        private bool HasListener(GameEventType eventType)
        {
        }

        public void Invoke(EventBase eventArgs)
        {
        }

        public void Invoke(GameEventType eventType)
        {
        }

        public void Invoke(GameEventType eventType, Hashtable eventParams)
        {
        }

        public void ResetAllListeners()
        {
        }

        public void ResetListener(GameEventType eventType)
        {
        }

        public void SetListener(GameEventType eventType, EventListenerDelegate listener)
        {
        }
    }
}

