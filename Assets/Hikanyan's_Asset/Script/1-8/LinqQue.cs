using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LinqQue : MonoBehaviour
{
    [SerializeField] CharacterMaster date;
    void Start()
    {
        var query = date.sheet
                    .Where (x =>x.Hp > 60)//条件に一致するものを絞り込む
                    .OrderBy (x => x.Hp)//指定キーを昇順でソートする
                    .Select (x => x.Name);//要素（表の縦の列）を選択する
        foreach(var name in query)
        {
            Debug.Log(name);
        }
    }
}
