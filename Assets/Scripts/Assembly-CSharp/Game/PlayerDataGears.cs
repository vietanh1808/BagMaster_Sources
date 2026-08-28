using System;
using System.Collections.Generic;

namespace Game
{
	[Serializable]
	public class PlayerDataGears
	{
		public List<OwnedItemEntity> EquippedGears;

		public List<int> ShowedGearInCombat;

		public List<GearUpgradeLevelProgress> GearLevels;

		public List<GearMasteryProgress> MasteryProgresses;

		public List<int> GearCollectionClaimed;
	}
}
