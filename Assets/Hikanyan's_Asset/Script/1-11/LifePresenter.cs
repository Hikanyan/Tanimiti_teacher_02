using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
///Presenterは参照を持つようにする
public class LifePresenter : MonoBehaviour
{
    [SerializeField] PlayerData _playerData;
    [SerializeField] LifeView _lifeView;

    private void Start()
    {
        //SubscribeでLifeの値をとると変わったときにLifeViewを変更する
        _playerData.Life.Subscribe(life =>
        {
            _lifeView.SetLife(life);
        }).AddTo(this);
    }
}
