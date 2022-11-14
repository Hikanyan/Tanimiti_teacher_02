using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRecord : IRecordKey, IRecordName, IRecordAttackPoint
{
	private int _key;
	public int Key => _key;
	private string _name;
	public string Name => _name;

	private string _talk;

	private int _attackPoint;
	public int AttackPoint => _attackPoint;

	public CharacterRecord(int key, string name, string talk, int attackPoint)
	{
		_key = key;
		_name = name;
		_talk = talk;
		_attackPoint = attackPoint;
	}

	public void Talk()
	{
		Debug.Log(_talk);
	}
}