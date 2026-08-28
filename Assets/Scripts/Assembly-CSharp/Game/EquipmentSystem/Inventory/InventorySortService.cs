namespace Game.EquipmentSystem.Inventory
{
	public class InventorySortService
	{
		private readonly PlayerInfo _playerInfo;

		private readonly InventoryMap _inventoryMap;

		public InventorySortService(PlayerInfo playerInfo, InventoryMap inventoryMap)
		{
		}

		public bool ValidateMethod(OwnedItemEntity item)
		{
			return false;
		}

		public int SortMethod(EquipmentDisplayData a, EquipmentDisplayData b)
		{
			return 0;
		}
	}
}
