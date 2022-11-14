using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class SSRDirector : MonoBehaviour
{
    [SerializeField] CharacterMaster date;
    private void Start()
    {
        Debug.Log($"SSRDirector{date.sheet.Any(x => x.Rarity == CharacterMaster.Rarity.SSR && x.Post == CharacterMaster.JobPost.Director)}");
    }
}
