namespace WorldGridLogic
{
    using Common.Logger;
    using SharedTypes;
    using System;
    using System.Runtime.CompilerServices;
    using WorldGridSharedTypes;

    public class AgressorPortal : IGridItem
    {
        private static readonly Common.Logger.Logger _log;
        public Action<AgressorPortal> OnArmyReceived;

        private AgressorPortal(bool revenge, bool callPlay)
        {
        }

        public static AgressorPortal Create(ArmyDescription victimArmy, bool revenge, bool callPlay)
        {
        }

        public static AgressorPortal CreateAndRequestFromServer(bool callPlay)
        {
        }

        public void RequestFromServer()
        {
        }

        public bool CallControllerPlay
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

        public int Height
        {
            get
            {
            }
        }

        public bool IsReady
        {
            get
            {
            }
        }

        public bool IsRequestSent
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

        public GridItemType ItemType
        {
            get
            {
            }
        }

        public SharedConsts.ServerResponseCodes ResponseCode
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

        public bool Revenge
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

        public ArmyDescription VictimArmy
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

        public int Width
        {
            get
            {
            }
        }
    }
}

