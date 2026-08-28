using System.Collections.Generic;
using System.Threading.Tasks;
using Game.Shop;
using UnityEngine;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Modal;

namespace Game.EventDungeon
{
	public class ModalEventDungeonPurchaseAdsTicket : Modal
	{
		[SerializeField]
		private Button buttonClose;

		[SerializeField]
		private Button buttonTapToClose;

		[SerializeField]
		private ValuePackShopItem prefab;

		[SerializeField]
		private Transform itemHolder;

		private readonly List<ValuePackShopItem> items;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnCloseClicked()
		{
		}

		public override Task WillPushEnter()
		{
			return null;
		}

		public static void Show(bool isPauseGame = false)
		{
		}
	}
}
