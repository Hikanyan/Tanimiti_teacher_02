using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTestGenericRecord : MonoBehaviour
{
	// Start is called before the first frame update
	private void Start()
	{
		var monsterRecords = new TestGenericWhereRecordList<MonsterRecord>();
		monsterRecords.Add(new MonsterRecord(0, "Slime",10));
		monsterRecords.Add(new MonsterRecord(1, "Dragon",20));
		monsterRecords.Add(new MonsterRecord(2, "skeleton",30));

		var monster = monsterRecords.GetRecord(0);

		Debug.Log(monster.Name);
		Debug.Log(monster.AttackPoint);
		monster.Shout();

		var characterRecords = new TestGenericWhereRecordList<CharacterRecord>();
		characterRecords.Add(new CharacterRecord(0, "ë∫êl", "Ç±ÇÒÇ…ÇøÇÕ",40));
		characterRecords.Add(new CharacterRecord(1, "ìXÇÃêl", "Ç¢ÇÁÇ¡ÇµÇ·Ç¢",50));

		var character = characterRecords.GetRecord(1);
		Debug.Log(character.Name);
		Debug.Log(character.AttackPoint);
		character.Talk();
	}

}