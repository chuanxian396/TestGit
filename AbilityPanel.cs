using Common.Logger;
using Eo.Battle;
using Eo.BattleLogic;
using Ether;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class AbilityPanel : UIWindow
{
    [SerializeField]
    private List<GameObject> _abilityEffects;
    [SerializeField, GameTag(Tag_UIForm.AbilityPanel_Slot1, new Tag_UIForm[] { Tag_UIForm.AbilityPanel_Slot2, Tag_UIForm.AbilityPanel_Slot3 })]
    private List<AbilitySlot> _abilitySlots;
    private ArenaMain _arena;
    private Eo.Battle.Unit _centerUnit;
    private Vector3 _etherlordHandStartPosition;
    [SerializeField]
    private UnityEngine.Color _etherlordsDisabledColor;
    [GameTag(Tag_UIForm.AbilityPanel_EtherlordsHand, new Tag_UIForm[] {  }), SerializeField]
    private UIButtonSwitch _etherlordsHandButton;
    [SerializeField]
    private Transform _etherlordsHandPanel;
    [SerializeField]
    private UILabel _etherlordsHandPriceLabel;
    [SerializeField]
    private Transform _etherlordsHandPriceRoot;
    [SerializeField]
    private UIForm _glyphEffectForm;
    [SerializeField]
    private List<GameObject> _glyphEffectPoints;
    private bool _invalidateUnits;
    private float _lastMana;
    private Eo.Battle.Unit _leftUnit;
    private static readonly Common.Logger.Logger _log;
    [SerializeField]
    private Transform _parent;
    [SerializeField]
    private ArenaManaBar _playerManaBar;
    private bool _resurrectionLastState;
    private Eo.Battle.Unit _rightUnit;
    private bool[] _unitCageLastState;
    private bool[] _unitDeadLastState;
    [CompilerGenerated]
    private static Action<Collider> <>f__am$cache25;
    [CompilerGenerated]
    private static Action<Collider> <>f__am$cache26;
    public static readonly int CENTER_UNIT_INDEX;
    private static UIForm.Event EVT_PLAYERS_TURN;
    private static UIForm.Event EVT_PLAYERS_TURN_ENDED;
    private static UIForm.Event EVT_SHOW;
    private static UIForm.Event EVT_SWAP_LEFT_CENTER;
    private static UIForm.Event EVT_SWAP_LEFT_RIGHT;
    private static UIForm.Event EVT_SWAP_RIGHT_CENTER;
    public static readonly int FIRST_ABILITY_SET_IDX;
    private static UIForm.Event FORM_EVENT_ETHERLORDS_HAND_USED;
    public static readonly int LEFT_ABILITY_IDX;
    public static readonly int LEFT_UNIT_INDEX;
    public static readonly int MIDDLE_ABILITY_IDX;
    public static readonly int RIGHT_ABILITY_IDX;
    public static readonly int RIGHT_UNIT_INDEX;
    public static readonly int SECOND_ABILITY_SET_IDX;

    private void _onAbilityClick(AbilitySlot slot)
    {
    }

    private void _onEtherlordsHandButtonClick()
    {
    }

    private void _setUnit(Eo.Battle.Unit unit, int idx)
    {
    }

    private void _setUnits()
    {
    }

    private void _updateUnit(Eo.Battle.Unit unit, int idx, float mana)
    {
    }

    public void emulateClick(Eo.Battle.Unit unit)
    {
    }

    public void hidePanel()
    {
    }

    public void onAbilityUsingStarted(Eo.Battle.Unit caster, bool isSpecial)
    {
    }

    protected override void onAwake()
    {
    }

    public void onBattleFinished()
    {
    }

    protected override void onEnable()
    {
    }

    protected override void onInitEvents()
    {
    }

    public void onRoundSystemStateChanged(RoundState currState)
    {
    }

    public void onUnitClicked(Eo.Battle.Unit unit)
    {
    }

    public void onUnitMove(UnitPos pos1, UnitPos pos2)
    {
    }

    protected override void onWindowShow()
    {
    }

    public void preparePanel()
    {
    }

    public void SetEtherlordsHandActive(bool active)
    {
    }

    public void SetEtherlordsHandEnabled(bool enabled)
    {
    }

    public void show(ArenaMain arena)
    {
    }

    public void showGlyphEffect(GameObject effect, UnitPos position)
    {
    }

    public void updateAllSlots(bool updateState = true)
    {
    }

    public void updateUnits()
    {
    }

    public UnityEngine.Color etherlordsDisabledColor
    {
        get
        {
        }
    }

    public UIForm getSwapObject
    {
        get
        {
        }
    }

    [CompilerGenerated]
    private sealed class <_onEtherlordsHandButtonClick>c__AnonStorey17A
    {
        internal AbilityPanel <>f__this;
        internal EtherWorldEconomicsManager.Receipt price;

        internal void <>m__29E()
        {
        }
    }
}

