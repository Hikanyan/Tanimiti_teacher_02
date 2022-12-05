using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UnityEngine.UI;
using System;
public class OnMouseDownAsDelay : MonoBehaviour
{
    [SerializeField] GameObject _box;
    [SerializeField] Button uiButton;
    void Start()
    {
        uiButton.OnMouseDownAsObservable()
        .ThrottleFirst(TimeSpan.FromSeconds(0.3f))
        .Delay(TimeSpan.FromSeconds(0.5f))
        .Subscribe(_ => MoveTransform());
    }
    void MoveTransform()
    {
        this.gameObject.transform.Translate(1, 0, 0);
        Debug.Log("�ړ�����");
    }
}
