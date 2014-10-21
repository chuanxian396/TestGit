using System;
using System.Collections.Generic;

[Serializable]
public class AbilityStorage : StorageBase<AbilityData>
{
    private static void AddAbilityEffectsToList(AbilityData ability, HashSet<string> list)
    {
    }

    private static void AddPassiveAbilityEffectsToList(PassiveAbilityData ability, HashSet<string> list)
    {
    }

    public static string[] GetEffectNames()
    {
    }

    public static string[] GetEffectNames(params int[] unitIds)
    {
    }

    public override string BinarySavePath
    {
        get
        {
        }
    }

    public override StorageType StorageType
    {
        get
        {
        }
    }
}

