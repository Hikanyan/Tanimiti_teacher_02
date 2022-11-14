using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class JobPostAllName : MonoBehaviour
{
    [SerializeField] CharacterMaster date;
    private void Start()
    {
        var query = date.sheet
            .Select(x => x.Name);
                            
        foreach (var name in query)
        {
            Debug.Log(name);
        }
    }
}
