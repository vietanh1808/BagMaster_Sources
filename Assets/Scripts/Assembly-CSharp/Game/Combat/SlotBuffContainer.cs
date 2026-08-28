using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class SlotBuffContainer : MonoBehaviour
	{
		private Dictionary<object, List<ISlotBuff>> _buffContainer;

		private HashSet<Gear> _gears;

		public void AddBuffToContainer(ISlotBuff buff, object source)
		{
		}

		public void RemoveBuffFromContainer(object source)
		{
		}

		public void ApplyBuffToGear(Gear gear)
		{
		}

		public void RemoveAllBuffFromGear(Gear gear)
		{
		}

		public void RemoveAllBuffFromGearPassCheck(Gear gear)
		{
		}
	}
}
