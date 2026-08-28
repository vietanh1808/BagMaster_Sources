using Game.Combat;

namespace Game.GearUpgrade
{
	public static class GearDataExtensions
	{
		public static bool IsMaxUpgraded(this GearData gearData, int level)
		{
			return false;
		}

		public static GearUpgradeData GetGearUpgradeData(this GearData gearData, int level)
		{
			return null;
		}

		public static bool IsMaxUpgraded(this GearData gearData)
		{
			return false;
		}

		public static GearUpgradeData GetGearUpgradeData(this GearData gearData)
		{
			return null;
		}

		public static bool IsUpgradeable(this GearData gearData)
		{
			return false;
		}

		public static GearMasteryData GetGearMasteryData(this GearData gearData)
		{
			return null;
		}

		public static bool IsMasteryClaimable(this GearData gearData)
		{
			return false;
		}

		public static bool IsCollectionClaimable(this GearData gearData)
		{
			return false;
		}
	}
}
