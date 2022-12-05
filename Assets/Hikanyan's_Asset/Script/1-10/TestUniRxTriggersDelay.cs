using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using System;
public class TestUniRxTriggersDelay : MonoBehaviour
{
    [SerializeField] GameObject _box;
    [SerializeField] Button uiButton;
    private int count;
    void Start()
    {
        uiButton.OnClickAsObservable()
        .Delay(TimeSpan.FromSeconds(0.5f))
        .ThrottleFirst(TimeSpan.FromSeconds(0.3f))
        .Subscribe(_ => MoveTransform());
    }
    void MoveTransform()
    {
        this.gameObject.transform.Translate(1, 0, 0);
        Debug.Log("ˆÚ“®‚µ‚½");
    }
}
