using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StringPairCollection", menuName = "Game/StringPairCollection")]
public class StringPairCollection : ScriptableObject
{
	[Serializable]
	public struct Pair
	{
		public string Key;

		public string Value;
	}

	[SerializeField]
	private List<Pair> _stringPairs;

	public string GetValue(string key)
	{
		return null;
	}
}
