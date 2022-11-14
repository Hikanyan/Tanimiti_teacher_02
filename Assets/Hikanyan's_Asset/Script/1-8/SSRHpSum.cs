using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class SSRHpSum : MonoBehaviour
{
    [SerializeField] CharacterMaster date;
    private void Start()
    {
        Debug.Log($"SSR HP SUM{date.sheet.Where(x=>x.Rarity == CharacterMaster.Rarity.SSR).Sum(x=>x.Hp)}");
    }
}
