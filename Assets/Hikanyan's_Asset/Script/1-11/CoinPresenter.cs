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
        //Subscribe‚ÅLife‚Ì’l‚ð‚Æ‚é‚Æ•Ï‚í‚Á‚½‚Æ‚«‚ÉLifeView‚ð•ÏX‚·‚é
        _coinData.Coin.Subscribe(coin =>
        {
            _coinView.SetCoin(coin);
        }).AddTo(this);
    }
}
