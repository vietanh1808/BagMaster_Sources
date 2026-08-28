using System.Collections.Generic;

namespace Game.EquipmentSystem
{
	public class EquipmentPriceData
	{
		public int Id;

		public int EquipmentId;

		public List<ResourceRequireData> Price;

		public EquipmentPriceData(int id, int equipmentId, List<ResourceRequireData> price)
		{
		}
	}
}
