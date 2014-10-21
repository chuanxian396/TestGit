namespace WorldGridSharedTypes
{
    using System;

    public interface IEventSystem
    {
        void ResetAllListeners();
        void ResetListener(GameEventType eventType);
        void SetListener(GameEventType eventType, EventListenerDelegate listener);
    }
}

