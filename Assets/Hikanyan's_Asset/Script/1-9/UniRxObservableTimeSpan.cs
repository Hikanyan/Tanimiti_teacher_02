using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class UniRxObservableTimeSpan : MonoBehaviour
{
    private void Start()
    {
        Observable.Timer(TimeSpan.FromMilliseconds(500))
            .Subscribe(_ => Debug.Log("500Œo‚Á‚½")).AddTo(this);
    }
}
