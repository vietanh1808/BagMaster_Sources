using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelCombatChestData
	{
		public int ID;

		public string Asset;

		public string Note;

		public int Common_rate;

		public int Uncommon_rate;

		public int Rare_rate;

		public int Epic_rate;

		public int Legend_rate;

		public int Mystic_rate;
	}
}
