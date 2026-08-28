using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class BagNewSlotManager : MonoBehaviour
	{
		[SerializeField]
		protected float _animationSlotAppearDelay;

		[Header("Debug")]
		[SerializeField]
		protected List<NewSlot> _allGearSlots;

		[SerializeField]
		protected List<NewSlot> _buyableGearSlots;

		[SerializeField]
		protected int _lowestPrice;

		private void OnDestroy()
		{
		}

		public virtual void AddNewSlots(NewSlot newSlot)
		{
		}

		public void Initialize()
		{
		}

		public bool IsMax()
		{
			return false;
		}

		public float GetLowestSlotPrice()
		{
			return 0f;
		}

		private void OnGoldChanged(int newGold)
		{
		}

		public void UpdateBuyableSlots()
		{
		}

		public virtual bool BuySlot()
		{
			return false;
		}

		private List<NewSlot> GetCheapestBuyableSlots()
		{
			return null;
		}
	}
}
