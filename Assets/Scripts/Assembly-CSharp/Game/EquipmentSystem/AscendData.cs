using System.Collections.Generic;

namespace Game.EquipmentSystem
{
	public class AscendData
	{
		public readonly int Id;

		public readonly List<ResourceRequireData> AscendRequires;

		public ResourceRequireData FragmentData => null;

		public AscendData(int id, List<ResourceRequireData> costDatas)
		{
		}
	}
}
