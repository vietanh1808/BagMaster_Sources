using System;
using System.Collections.Generic;

namespace Game
{
	[Serializable]
	public class PlayerDataInventory
	{
		public List<OwnedResourceEntity> EquipmentLevels;

		public List<int> OwnedIds;

		public List<int> EquippedIds;
	}
}
