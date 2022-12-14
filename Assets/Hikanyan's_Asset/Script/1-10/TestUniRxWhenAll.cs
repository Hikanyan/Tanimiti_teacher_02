using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
public class TestUniRxWhenAll : MonoBehaviour
{
    private void Start()
    {
        var testA = Observable.Timer(TimeSpan.FromSeconds(1.0f)).Do(_ => Debug.Log("1秒待った"));
        var testB = Observable.Timer(TimeSpan.FromSeconds(2.0f)).Do(_ => Debug.Log("2秒待った"));
        var testC = Observable.Timer(TimeSpan.FromSeconds(3.0f)).Do(_ => Debug.Log("3秒待った"));
        Observable.WhenAll(testA, testB, testC).Subscribe(_ =>
        {
            Debug.Log("全て終了");
        }).AddTo(this);
    }
}
