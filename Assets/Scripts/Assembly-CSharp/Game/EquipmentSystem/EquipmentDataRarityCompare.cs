using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Game.EquipmentSystem
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct EquipmentDataRarityCompare : IComparer<EquipmentData>
	{
		public int Compare(EquipmentData x, EquipmentData y)
		{
			return 0;
		}

		private int GetTypeOrder(EquipmentPart type)
		{
			return 0;
		}
	}
}
