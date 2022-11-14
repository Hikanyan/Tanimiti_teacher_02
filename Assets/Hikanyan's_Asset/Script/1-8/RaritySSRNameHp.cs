using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class RaritySSRNameHp : MonoBehaviour
{
    [SerializeField] CharacterMaster date;
    private void Start()
    {
        var query = date.sheet
            .Where(x => x.Rarity == CharacterMaster.Rarity.SSR)
            .OrderByDescending(x => x.Hp);

        foreach(var name in query)
        {
            Debug.Log($"ñºëOÅF{name.Name}\nHPÅF{name.Hp}");
        }
    }
}
