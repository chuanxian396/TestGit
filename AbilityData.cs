using Eo.Battle;
using Eo.BattleLogic;
using Eo.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

[Serializable]
public class AbilityData : IStorageData
{
    private List<string> DescriptionArgsCondition_cached;
    [SerializeField]
    private List<AbilityAction> m_actions;
    [SerializeField]
    private AbilityActionSpace m_actionSpace;
    [SerializeField]
    private List<AdditionAbilityAction> m_additionalActions;
    [SerializeField]
    private UnitAnim m_animation;
    [SerializeField]
    private bool m_aoeCamera;
    [SerializeField]
    private float m_cameraDuration;
    [SerializeField]
    private string m_cameraName;
    [SerializeField]
    private string m_casterEffect;
    [SerializeField]
    private EffectAnchorType m_casterEffectAnchor;
    [SerializeField]
    private int m_descriptionArgCondition;
    [SerializeField]
    private List<string> m_descriptionArgs;
    [SerializeField]
    private string m_globalEffect;
    [SerializeField]
    private bool m_globalEffectOnAnimStart;
    [SerializeField]
    private int m_hitEffectId;
    [SerializeField]
    private List<string> m_icons;
    [SerializeField]
    private int m_id;
    [SerializeField]
    private ShakeCamera[] m_shakeCamera;
    [SerializeField]
    private AbilityTags m_tags;

    public static bool Exist(int id)
    {
    }

    public static AbilityData Get(int id)
    {
    }

    public string GetDesc(int level)
    {
    }

    public string GetIcon(int level)
    {
    }

    public string GetName(int level, Language language)
    {
    }

    public ReadOnlyCollection<AbilityAction> Actions
    {
        get
        {
        }
    }

    public AbilityActionSpace ActionSpace
    {
        get
        {
        }
    }

    public ReadOnlyCollection<AdditionAbilityAction> AdditionalActions
    {
        get
        {
        }
    }

    public UnitAnim Animation
    {
        get
        {
        }
    }

    public bool AoeCamera
    {
        get
        {
        }
    }

    public float CameraDuration
    {
        get
        {
        }
    }

    public string CameraName
    {
        get
        {
        }
    }

    public string CasterEffect
    {
        get
        {
        }
    }

    public EffectAnchorType CasterEffectAnchor
    {
        get
        {
        }
    }

    public string Desc
    {
        get
        {
        }
    }

    public ReadOnlyCollection<string> DescriptionArgs
    {
        get
        {
        }
    }

    public ReadOnlyCollection<string> DescriptionArgsCondition
    {
        get
        {
        }
    }

    public string GlobalEffect
    {
        get
        {
        }
    }

    public bool GlobalEffectOnAnimStart
    {
        get
        {
        }
    }

    public int HitEffectId
    {
        get
        {
        }
    }

    public int Id
    {
        get
        {
        }
    }

    public bool IsSelfKill
    {
        get
        {
        }
    }

    public string Name
    {
        get
        {
        }
    }

    public ShakeCamera ShakeCamera
    {
        get
        {
        }
    }

    public AbilityTags Tags
    {
        get
        {
        }
    }
}

