using System;
using System.Collections.Generic;
using Game.Combat;

namespace DoorServices
{
	[Serializable]
	public class BackpackContextData
	{
		public string[] gears;

		public int[] buffs;

		public FieldContextData field;

		public HandContextData hand;

		public float game_cp;

		public static BackpackContextData BuildCurrent(float? power = null)
		{
			return null;
		}

		public Dictionary<string, object> ToDict()
		{
			return null;
		}

		public string ToJson()
		{
			return null;
		}

		public static Dictionary<string, object> BuildCurrentDict()
		{
			return null;
		}

		public static string BuildCurrentJson(float? power = null)
		{
			return null;
		}

		public static BackpackContextData BuildFromSave(CombatSaveData saveData)
		{
			return null;
		}
	}
}
