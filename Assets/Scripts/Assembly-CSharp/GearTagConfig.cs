using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[Obsolete]
[CreateAssetMenu(fileName = "GearTagConfig", menuName = "Game/GearTagConfig")]
public class GearTagConfig : SerializedScriptableObject
{
	[SerializeField]
	private Dictionary<string, Color> _colors;

	public Color GetColor(string id)
	{
		return default;
	}
}
