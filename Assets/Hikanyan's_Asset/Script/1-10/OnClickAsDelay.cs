using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UnityEngine.UI;
using System;
public class OnClickAsDelay : MonoBehaviour
{
    [SerializeField] Button uiButton;
    void Start()
    {
        uiButton.OnClickAsObservable()
        .Delay(TimeSpan.FromSeconds(0.5f))
        .Subscribe(_ => ClickLog());
    }
    void ClickLog()
    {
        Debug.Log("ƒNƒŠƒbƒN‚³‚ê‚½");
    }
}