namespace WorldGridLogic
{
    using System;
    using System.Runtime.CompilerServices;
    using WorldGridSharedTypes;

    public class BossEncounter : Encounter
    {
        private BossEncounter(int bossId)
        {
        }

        public static BossEncounter Create(int bossId)
        {
        }

        public int BossId
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
    }
}

