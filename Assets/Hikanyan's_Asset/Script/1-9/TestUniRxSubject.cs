using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using System;
public class TestUniRxSubject : MonoBehaviour
{
    Subject<string> attackSubject = new Subject<string>();

    // Start is called before the first frame update
    void Start()
    {
        attackSubject
        .ThrottleFirst(TimeSpan.FromSeconds(2))
            .Subscribe(text => Debug.Log("�C�x���g����:" + text));

        //attackSubject.OnNext("�U����������");
        // attackSubject.OnNext("������������");

    }

    // Update is called once per frame
    void Update()
    {
        attackSubject.OnNext("�U����������");
        attackSubject.OnNext("������������");
    }
}
