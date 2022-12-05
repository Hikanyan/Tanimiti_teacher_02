using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TestUniRxTriggersUnityEvent : MonoBehaviour
{
    [SerializeField] Button uiButton;
    private int count;
    void Start()
    {
        uiButton.OnClickAsObservable()
        .ThrottleFirst(TimeSpan.FromSeconds(0.5f))
        .Subscribe(_ => OnButtonClick());
    }
    void OnButtonClick()
    {
        count++;
        Debug.Log("ButtonCount" + count);
    }
}