using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
public class TestUniRxWhenAll : MonoBehaviour
{
    private void Start()
    {
        var testA = Observable.Timer(TimeSpan.FromSeconds(1.0f)).Do(_ => Debug.Log("1•b‘Ò‚Á‚½"));
        var testB = Observable.Timer(TimeSpan.FromSeconds(2.0f)).Do(_ => Debug.Log("2•b‘Ò‚Á‚½"));
        var testC = Observable.Timer(TimeSpan.FromSeconds(3.0f)).Do(_ => Debug.Log("3•b‘Ò‚Á‚½"));
        Observable.WhenAll(testA, testB, testC).Subscribe(_ =>
        {
            Debug.Log("‘S‚ÄI—¹");
        }).AddTo(this);
    }
}
