using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
public class UniRxTest : MonoBehaviour
{
    private void Start()
    {
        Observable.NextFrame().Subscribe(_ => 
        { 
            Debug.Log("1�t���[����Ɏ��s"); 
        }).AddTo(this);
        Debug.Log("�����Ɏ��s");
    }
}
