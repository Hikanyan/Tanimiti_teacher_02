using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
public class BuySell : MonoBehaviour
{
    [SerializeField] int _coin;
    [SerializeField] CoinData _coinData;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => OnBuySell(_coin));
    }
    void OnBuySell(int value)
    {
        _coinData.GetCoin(value);
    }
}
