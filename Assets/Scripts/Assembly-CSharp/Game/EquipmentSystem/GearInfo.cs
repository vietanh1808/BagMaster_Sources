using Game.Combat;
using UnityEngine;

namespace Game.EquipmentSystem
{
	public abstract class GearInfo : MonoBehaviour
	{
		public GearData Data { get; protected set; }

		public OwnedItemEntity OwnedGear { get; protected set; }

		public void UpdateGearInfo(GearData data, OwnedItemEntity owned)
		{
		}

		public void UpdateGearInfo(GearInfo other)
		{
		}

		protected abstract void UpdateGearInfo();

		public virtual void Clear()
		{
		}
	}
}
