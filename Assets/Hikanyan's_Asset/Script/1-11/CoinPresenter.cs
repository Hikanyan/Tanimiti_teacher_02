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
        //SubscribeでLifeの値をとると変わったときにLifeViewを変更する
        _coinData.Coin.Subscribe(coin =>
        {
            _coinView.SetCoin(coin);
        }).AddTo(this);
    }
}
