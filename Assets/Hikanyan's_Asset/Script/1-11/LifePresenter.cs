using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
///Presenter�͎Q�Ƃ����悤�ɂ���
public class LifePresenter : MonoBehaviour
{
    [SerializeField] PlayerData _playerData;
    [SerializeField] LifeView _lifeView;

    private void Start()
    {
        //Subscribe��Life�̒l���Ƃ�ƕς�����Ƃ���LifeView��ύX����
        _playerData.Life.Subscribe(life =>
        {
            _lifeView.SetLife(life);
        }).AddTo(this);
    }
}
