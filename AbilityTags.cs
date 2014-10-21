using System;
using System.Collections.Generic;
using UnityEngine;
  
[Serializable]
public class AbilityTags
{
    [SerializeField]
    private List<Type> m_values;

    public bool Has(Type tag)
    {
    }

    public bool Is(Type tag)
    {
    }

    public enum Type
    {
        None,
        AutoAbility,
        SpecialAbility
    }
	对方的发送到放大师傅的说法
}

