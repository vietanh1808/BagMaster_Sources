using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu(fileName = "StatIconConfig", menuName = "Game/StatIconConfig")]
	public class StatIconConfig : SerializedScriptableObject
	{
		[SerializeField]
		private Dictionary<int, Sprite> _icons;

		private static StatIconConfig _default;

		public static StatIconConfig Default => null;

		public Sprite GetIcon(int id)
		{
			return null;
		}
	}
}
