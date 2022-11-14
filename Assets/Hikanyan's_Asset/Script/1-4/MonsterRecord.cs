using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterRecord : IRecordKey, IRecordName, IRecordAttackPoint
{
	private int _key;
	public int Key => _key;
	private string _name;
	public string Name => _name;

	private int _attackPoint;
	public int AttackPoint => _attackPoint;

	public MonsterRecord(int key, string name,int attackPoint)
	{
		_key = key;
		_name = name;
		_attackPoint = attackPoint;
	}

	public void Shout()
	{
		Debug.Log("Gao!");
	}
}