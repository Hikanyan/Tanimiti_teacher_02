using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TestGenericWhereRecordList<T> where T : class, IRecordKey, IRecordName, IRecordAttackPoint
{
	private List<T> recordParams;

	public TestGenericWhereRecordList()
	{
		recordParams = new List<T>();
	}

	public void Add(T record)
	{
		recordParams.Add(record);
	}

	public T GetRecord(int key)
	{
		foreach (T record in recordParams)
		{
			if (record.Key == key)
			{
				return record;
			}
		}

		return null;
	}

	public T GetRecord(string name)
	{
		foreach (T record in recordParams)
		{
			if (record.Name == name)
			{
				return record;
			}
		}

		return null;
	}
}