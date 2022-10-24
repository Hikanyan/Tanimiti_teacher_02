using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGenericStack<T>
{
	private int stackIndex = 0;
	private T[] stackArray;
	private readonly int maxStack = 10;

	public TestGenericStack()
	{
		stackArray = new T[maxStack];
	}

	public void Push(T value)
	{
		if (stackIndex <= maxStack)
		{
			stackArray[stackIndex] = value;
			stackIndex++;
			return;
		}

		Debug.Log("StackMax");
	}

	public T Pop()
	{
		if (stackIndex == 0)
		{
			return stackArray[0];
		}

		stackIndex--;
		return stackArray[stackIndex];
	}
}