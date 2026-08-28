using Game.Combat;

namespace Game
{
	public static class GearDataExtensions
	{
		public static GearLog.Type GetLogType(this GearData gearData)
		{
			return GearLog.Type.Damage;
		}

		public static bool IsGearInBag(this CombatSaveData.GearData gear)
		{
			return false;
		}

		public static int CompareGearLogValue(this CombatSaveData.GearData a, CombatSaveData.GearData b)
		{
			return 0;
		}
	}
}
