using System;
using Game;
using Game.EquipmentSystem;

namespace DoorServices
{
	[Serializable]
	public class StatsContextData
	{
		public EquipmentContextData weapon;

		public EquipmentContextData armor;

		public EquipmentContextData necklace;

		public EquipmentContextData helmet;

		public int talent_level;

		public int talent_level_1;

		public HandContextData hand;

		public float meta_cp;

		public static StatsContextData BuildCurrent()
		{
			return null;
		}

		public static string BuildCurrentJson()
		{
			return null;
		}

		private static EquipmentContextData BuildEquipmentContext(PlayerInfo playerInfo, EquipmentPart part)
		{
			return null;
		}
	}
}
