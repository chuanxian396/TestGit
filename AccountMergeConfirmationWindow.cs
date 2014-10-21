using System;
using UnityEngine;

public class AccountMergeConfirmationWindow : UIWindow
{
    [SerializeField]
    private UIButton2 _closeButton;
    [SerializeField]
    private UIButton2 _confirmButton;
    [SerializeField]
    private UIInput _inputField;
    [SerializeField]
    private UILabel _messageLabel;
    private string _referenceString;
    public System.Action onAction;
    public string playerName;

    protected override void onAwake()
    {
    }

    protected override void onWindowShow()
    {
    }

    public static void ShowAndConfirmDeleteGuestAccount(System.Action onConfirm)
    {
    }
}

