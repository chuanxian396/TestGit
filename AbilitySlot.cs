using Eo.Battle;
using Eo.BattleLogic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AbilitySlot : UIForm
{
    [SerializeField]
    private string _abilityActiveSpriteName;
    [SerializeField]
    private UITexture _abilityIcon;
    [SerializeField]
    private string _abilityInactiveSpriteName;
    [SerializeField]
    private BitmapMeshText _abilityPredictionDamageLabel;
    [SerializeField]
    private string _abilityPredictionDamageSpriteName;
    [SerializeField]
    private BitmapMeshText _abilityPredictionHealLabel;
    [SerializeField]
    private string _abilityPredictionHealSpriteName;
    [SerializeField]
    private GameObject _abilityPredictionObject;
    [SerializeField]
    private UISprite _abilityPredictionSprite;
    private Dictionary<int, List<string>> _activateAnimations;
    private bool _activated;
    [SerializeField]
    private GameObject _baseButton;
    [SerializeField]
    private UISprite _buffIcon;
    private GameObject _chaotActiveChargeEffect;
    [SerializeField]
    private UISprite _debuffIcon;
    private MyCoroutine _delayedAnimCoroutine;
    [SerializeField]
    private float _enableAnimDelay;
    private bool _foreground;
    private float _hightlightAfterTimeStamp;
    private bool _isHighlighted;
    private bool _isOrdered;
    private GameObject _kinetActiveChargeEffect;
    private UnitChargeState? _lastChargeState;
    private float _playerMana;
    [SerializeField]
    private float _predictionBgroundScaleDelta;
    [SerializeField]
    private UISprite _raceIcon;
    private State _state;
    private List<string> _switchAnimations;
    private GameObject _vitalActiveChargeEffect;
    public static UIForm.Event FORM_EVENT_CAST;
    public static UIForm.Event FORM_EVENT_CAST_DISABLED;
    public static UIForm.Event FORM_EVENT_DEAD;
    public static UIForm.Event FORM_EVENT_DISABLE;
    public static UIForm.Event FORM_EVENT_ENABLE;
    public static UIForm.Event FORM_EVENT_HIGHLIGHT;
    private static UIForm.Event FORM_EVENT_PRESSED;
    private static UIForm.Event FORM_EVENT_RELEASED;
    public Action<AbilitySlot> onClick;

    private void _disableChargeEffect()
    {
    }

    private void _onPress(GameObject go, bool isPressed)
    {
    }

    [DebuggerHidden]
    private IEnumerator _playEnableEffectDelayed()
    {
    }

    private void _sampleInactiveState()
    {
    }

    private void _setPrediction()
    {
    }

    private void _setPredictionBuffDebuff(ActionPrediction.Type type)
    {
    }

    private void _setPredictionDamageHeal(ActionPrediction.Type type, int multiplier, float minValue, float maxValue)
    {
    }

    private void _setPredictionDamageHealByPos(ActionPrediction.Type type, float[] effectByPosition)
    {
    }

    private void _setPredictionValue(UISprite bground, BitmapMeshText label, int minValue, int maxValue, int multiplier)
    {
    }

    private void _setPredictionValueByPos(UISprite bground, BitmapMeshText label, int[] values)
    {
    }

    private void _updateChargeEffect()
    {
    }

    private void _updateState()
    {
    }

    private GameObject CreateGlyphChargeEffect(UnitRace race)
    {
    }

    private string GetAOEEffectFormat(int maxValue, int multiplier)
    {
    }

    private string GetEffectFormat(int[] values)
    {
    }

    private string GetMulEffectFormat(int minValue, int maxValue)
    {
    }

    public void onAbilityUsingStarted(Eo.Battle.Unit caster, bool isSpecial)
    {
    }

    protected override void onAwake()
    {
    }

    private void OnDisable()
    {
    }

    protected override void onInitEvents()
    {
    }

    public void onRoundSystemStateChange(RoundState currState)
    {
    }

    protected override void onUpdate()
    {
    }

    public void playDisableEffect()
    {
    }

    public void playEnableEffect()
    {
    }

    public void playPushEffect()
    {
    }

    public void reset()
    {
    }

    public void setAbility(Ability ability)
    {
    }

    public void setOrdered()
    {
    }

    public void setParams(float currMana, bool updateState)
    {
    }

    public void setUnit(Eo.Battle.Unit unit)
    {
    }

    public ArenaMain arenaMain
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

    public bool isAfterSwap
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

    public bool isHighlighted
    {
        get
        {
        }
        set
        {
        }
    }

    public State state
    {
        get
        {
        }
        set
        {
        }
    }

    public Eo.Battle.Unit unit
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

    [CompilerGenerated]
    private sealed class <_playEnableEffectDelayed>c__Iterator6C : IDisposable, IEnumerator, IEnumerator<object>
    {
        internal object $current;
        internal int $PC;
        internal AbilitySlot <>f__this;

        [DebuggerHidden]
        public void Dispose()
        {
        }

        public bool MoveNext()
        {
        }

        [DebuggerHidden]
        public void Reset()
        {
        }

        object IEnumerator<object>.Current
        {
            [DebuggerHidden]
            get
            {
            }
        }

        object IEnumerator.Current
        {
            [DebuggerHidden]
            get
            {
            }
        }
    }

    public enum State
    {
        Inactive,
        Active,
        Waiting,
        Dead,
        Invalid
    }
}

