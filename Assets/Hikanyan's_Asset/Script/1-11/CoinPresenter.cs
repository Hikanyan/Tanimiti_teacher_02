using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
public class CoinPresenter : MonoBehaviour
{
    [SerializeField] CoinData _coinData;
    [SerializeField] CoinView _coinView;

    private void Start()
    {
        //Subscribe��Life�̒l���Ƃ�ƕς�����Ƃ���LifeView��ύX����
        _coinData.Coin.Subscribe(coin =>
        {
            _coinView.SetCoin(coin);
        }).AddTo(this);
    }
}
