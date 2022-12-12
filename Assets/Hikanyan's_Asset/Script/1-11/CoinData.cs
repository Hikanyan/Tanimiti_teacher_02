using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CoinData : MonoBehaviour
{
    public IntReactiveProperty Coin = new IntReactiveProperty();
    public void GetCoin(int value) => Coin.Value += value;
    private void OnDestroy() => Coin.Dispose();
}
