using System.Collections.Generic;

namespace Game.EquipmentSystem.Fuse
{
	public class FuseMap
	{
		public class Data
		{
			public EquipmentData MainEquipment;

			public List<OwnedItemEntity> List;

			public bool IncludeMain;

			public bool IsFuseable()
			{
				return false;
			}
		}

		private Dictionary<EquipmentData, Data> _fuseMap;

		public IEnumerable<KeyValuePair<EquipmentData, Data>> GetFuseables()
		{
			return null;
		}

		public bool AnyFuseableItems()
		{
			return false;
		}

		public bool AnyAutoFuseableItems()
		{
			return false;
		}

		public bool IsFuseable(EquipmentData equipmentData)
		{
			return false;
		}

		public IReadOnlyList<OwnedItemEntity> GetFuseableItems(EquipmentData equipmentData)
		{
			return null;
		}

		public void Build()
		{
		}

		private Data LoadFuseableItems(EquipmentData equipmentData, IReadOnlyCollection<OwnedItemEntity> allItems)
		{
			return null;
		}

		public void LogFuseMap()
		{
		}
	}
}
