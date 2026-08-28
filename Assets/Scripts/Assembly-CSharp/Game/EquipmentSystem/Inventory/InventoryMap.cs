using System.Collections.Generic;

namespace Game.EquipmentSystem.Inventory
{
	public class InventoryMap
	{
		private readonly PlayerInfo _playerInfo;

		private Dictionary<EquipmentPart, OwnedItemEntity> _currentEquippedItems;

		private Dictionary<EquipmentPart, int> _highestRarityCompare;

		public IReadOnlyDictionary<EquipmentPart, OwnedItemEntity> CurrentEquippedItems => null;

		public IReadOnlyDictionary<EquipmentPart, int> HighestRarityCompares => null;

		public InventoryMap(PlayerInfo playerInfo)
		{
		}

		public bool IsBetterThanEquipped(EquipmentData data)
		{
			return false;
		}

		public bool HasEquipped(EquipmentData data)
		{
			return false;
		}

		public void Build()
		{
		}
	}
}
