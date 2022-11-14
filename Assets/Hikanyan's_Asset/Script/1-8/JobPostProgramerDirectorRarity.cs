using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class JobPostProgramerDirectorRarity : MonoBehaviour
{
    [SerializeField] CharacterMaster date;
    private void Start()
    {
        var search = date.sheet
            .Where(x => x.Post == CharacterMaster.JobPost.Programer||x.Post == CharacterMaster.JobPost.Director)
            .OrderByDescending(x => x.Rarity);

        foreach (var chara in search)
        {
            Debug.Log($"{chara.ToString()}\n{chara.Post.ToString()}");
        }
    }
}
