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
            Debug.Log("1フレーム後に実行"); 
        }).AddTo(this);
        Debug.Log("直ぐに実行");
    }
}
