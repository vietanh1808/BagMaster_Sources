using System.Collections.Generic;

namespace Game.GearUpgrade
{
	public class GearUpgradeData
	{
		public int Id;

		public int Level;

		public ResourceRequireData CardRequired;

		public List<ResourceRequireData> UpgradeRequires;

		public List<StatModifierData> StatModifiers;

		public static GearUpgradeData Default => null;

		public bool IsUpgradable()
		{
			return false;
		}
	}
}
