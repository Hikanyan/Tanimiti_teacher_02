using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreText;

    public void SetCoin(int coinCount)
    {
        _scoreText.text = $"Coin : {coinCount}";
    }
}
