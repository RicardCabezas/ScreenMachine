using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartupStateUiView : UiView
{
    [SerializeField]
    private Button presentButton;

    [SerializeField]
    private Button pushButton;

    public event Action OnPresentRequested;

    public event Action OnPushRequested;

    private void OnEnable() {
        presentButton.onClick.AddListener(FirePresentAction);
        pushButton.onClick.AddListener(FirePushAction);
    }

    private void OnDisable() {
        presentButton.onClick.RemoveListener(FirePresentAction);
        pushButton.onClick.RemoveListener(FirePushAction);
    }

    private void FirePresentAction() {
        OnPresentRequested?.Invoke();
    }

    private void FirePushAction() {
        OnPushRequested?.Invoke();
    }
}
