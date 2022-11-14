using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObject/ShopItemMasterAsset")]
public class ShopItemMaster : ScriptableObject
{
    public List<ShopItem> Items;
    [System.Serializable]
    public class ShopItem
    {
        public int Id;
        public string Name;
        public string Efficacy;
        public int SellPrice;
    }
}
