using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class SRHP50 : MonoBehaviour
{
    [SerializeField] CharacterMaster date;
    private void Start()
    {
        var target = date.sheet
            .FirstOrDefault(x=>x.Rarity==CharacterMaster.Rarity.SR &&
            x.Hp >50);
        Debug.Log($"SR HP50 OverF{target.Name}\n{target.Post.ToString()}");
    }
}
