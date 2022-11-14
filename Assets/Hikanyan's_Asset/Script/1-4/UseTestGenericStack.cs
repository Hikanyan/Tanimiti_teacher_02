using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTestGenericStack : MonoBehaviour
{
	// Start is called before the first frame update
	private void Start()
	{
		var stackFloat = new TestGenericStack<float>();
		stackFloat.Push(4.2f);
		stackFloat.Push(3.5f);
		stackFloat.Push(2.1f);

		Debug.Log(stackFloat.Pop());
		Debug.Log(stackFloat.Pop());
		Debug.Log(stackFloat.Pop());

		var stackString = new TestGenericStack<string>();
		stackString.Push("ï∂éöóÒÇ‡");
		stackString.Push("Ç¢ÇØÇÈÇÊÅI");
		stackString.Push("ï÷óò");

		Debug.Log(stackString.Pop());
		Debug.Log(stackString.Pop());
		Debug.Log(stackString.Pop());

		var stackInt = new TestGenericStack<int>();
		stackInt.Push(2);
		stackInt.Push(6);
		stackInt.Push(3);

		Debug.Log(stackInt.Pop());
		Debug.Log(stackInt.Pop());
		Debug.Log(stackInt.Pop());

	}

}