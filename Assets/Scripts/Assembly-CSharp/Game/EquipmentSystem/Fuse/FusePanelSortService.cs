namespace Game.EquipmentSystem.Fuse
{
	public class FusePanelSortService
	{
		private readonly PlayerInfo _playerInfo;

		private readonly EquipmentListViewV2<Item> _equipmentListView;

		private readonly FuseMap _fuseMap;

		public FusePanelSortService(PlayerInfo playerInfo, EquipmentListViewV2<Item> equipmentListView, FuseMap fuseMap)
		{
		}

		public bool ValidateMethod(OwnedItemEntity item)
		{
			return false;
		}

		public void SortFuseable(EquipmentData equipmentData, OwnedItemEntity ownedItem)
		{
		}

		public void SortDefault()
		{
		}

		public int DefaultCompare(EquipmentDisplayData a, EquipmentDisplayData b)
		{
			return 0;
		}

		private int OtherwiseSort(EquipmentDisplayData a, EquipmentDisplayData b)
		{
			return 0;
		}
	}
}
