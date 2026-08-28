using System.Collections.Generic;

namespace Game.EquipmentSystem.Fuse
{
	public static class EquipmentDataFusionExtensions
	{
		public static bool CanFuseWith(this EquipmentData self, EquipmentData otherEquipmentData)
		{
			return false;
		}

		private static bool CanFuseWith(this EquipmentData self, ref int index, EquipmentData otherEquipmentData)
		{
			return false;
		}

		public static List<EquipmentFuseInfo?> GetFusionInfo(this EquipmentData equipmentData)
		{
			return null;
		}

		private static EquipmentFuseInfo? GetEquipmentFuseInfo(this EquipmentData self, ref int index)
		{
			return null;
		}
	}
}
