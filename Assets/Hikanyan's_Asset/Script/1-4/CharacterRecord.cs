using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRecord : IRecordKey, IRecordName
{
	private int _key;
	public int Key => _key;
	private string _name;
	public string Name => _name;

	private string _talk;

	public CharacterRecord(int key, string name, string talk)
	{
		_key = key;
		_name = name;
		_talk = talk;
	}

	public void Talk()
	{
		Debug.Log(_talk);
	}
}