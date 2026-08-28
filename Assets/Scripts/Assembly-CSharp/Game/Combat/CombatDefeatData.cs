using System;
using System.Collections;

namespace Game.Combat
{
	[Serializable]
	public class CombatDefeatData : CombatSaveData
	{
		public int ContinueCount;

		public void SetData(CombatSaveData saveData)
		{
		}

		private static bool IsList(Type fieldType)
		{
			return false;
		}

		private static IList CloneList(IList list)
		{
			return null;
		}
	}
}
