using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/CreateAsset")]
public class CharacterMaster : ScriptableObject
{
    public List<CharacterMasterRecord> sheet;

    public enum JobPost
    {
        Programer,
        Modeler,
        Motion,
        Director
    }

    public enum Rarity
    {
        N = 0,
        R = 1,
        SR = 2,
        SSR = 3
    }


    [Serializable]
    public class CharacterMasterRecord
    {
        public string Name;
        public int Hp;
        public CharacterMaster.Rarity Rarity;
        public CharacterMaster.JobPost Post;
    }
}
