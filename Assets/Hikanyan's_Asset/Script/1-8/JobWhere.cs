using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class JobWhere : MonoBehaviour
{
    [SerializeField] CharacterMaster date;
    void Start()
    {
        Debug.Log($"Director : {date.sheet.Count(x => x.Post == CharacterMaster.JobPost.Director)}"); 
        Debug.Log($"Modeler : {date.sheet.Count(x => x.Post == CharacterMaster.JobPost.Modeler)}"); 
        Debug.Log($"Motion : {date.sheet.Count(x => x.Post == CharacterMaster.JobPost.Motion)}"); 
        Debug.Log($"Programer : {date.sheet.Count(x => x.Post == CharacterMaster.JobPost.Programer)}"); 

    }
}
