using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScene : MonoBehaviour
{
    [SerializeField] ShopItemMaster _shopItemMaster;
    [SerializeField] List<int> _items = new();
    [SerializeField] GameObject _prefab;
    private void Start()
    {
        int itemIndex = 0;
        foreach(var item in _shopItemMaster.Items)
        {
            Debug.Log(item.Name);
            Debug.Log(item.Id);
            Debug.Log(item.Efficacy);
            Debug.Log(item.SellPrice);
            Instantiate(_prefab);
        }
    }
}
