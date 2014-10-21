namespace WorldGridLogic
{
    using SharedTypes;
    using System;
    using System.Runtime.CompilerServices;
    using WorldGridSharedTypes;

    public class DefenderPortal : Encounter
    {
        private DefenderPortal(ArmyStack armies, int stolenEther)
        {
        }

        public static DefenderPortal Create(ArmyStack armies, int stolenEther)
        {
        }

        public ArmyStack Armies
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

        public override WorldGridSharedTypes.EncounterType EncounterType
        {
            get
            {
            }
        }

        public int StolenEther
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

