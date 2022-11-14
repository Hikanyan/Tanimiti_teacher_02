using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class SSRSRRN : MonoBehaviour
{
    [SerializeField] CharacterMaster date;
    private void Start()
    {
        Debug.Log($"SSR{date.sheet.Count(x => x.Rarity == CharacterMaster.Rarity.SSR)}");
        Debug.Log($"SSR{date.sheet.Count(x => x.Rarity == CharacterMaster.Rarity.SR)}");
        Debug.Log($"SSR{date.sheet.Count(x => x.Rarity == CharacterMaster.Rarity.R)}");
        Debug.Log($"SSR{date.sheet.Count(x => x.Rarity == CharacterMaster.Rarity.N)}");
    }
}
