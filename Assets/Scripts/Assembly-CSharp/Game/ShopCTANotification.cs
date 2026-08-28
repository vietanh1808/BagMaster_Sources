using System.Collections.Generic;
using Game.Shop;
using UnityEngine;

namespace Game
{
	public class ShopCTANotification : MonoBehaviour
	{
		[SerializeField]
		private GameObject _notification;

		[SerializeField]
		private bool _hasEventListener;

		private List<ShopPackData> _hasFreePerDayPacks;

		private List<ShopPackData> _hasFreePricePacks;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void GetFreeablePacks()
		{
		}

		private bool InCategories(ShopPackData shopPackData)
		{
			return false;
		}

		public void Check()
		{
		}

		private bool GachaChestHasFree()
		{
			return false;
		}

		private bool CheckFreePerDayPacks()
		{
			return false;
		}

		private bool CheckFreeablePacks()
		{
			return false;
		}
	}
}
