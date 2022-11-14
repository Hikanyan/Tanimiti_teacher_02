using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LinqWordLength : MonoBehaviour
{
    void Start()
    {
        string word = "red green blue blue green blue";
        var wordArray = word.Trim().Split(' ');
        var uniqueWord = word.Distinct();
        foreach(var w in uniqueWord)
        {
            Debug.Log($"{w}\n{ wordArray.Count(x=>x==word)}");
        }
    }
}
