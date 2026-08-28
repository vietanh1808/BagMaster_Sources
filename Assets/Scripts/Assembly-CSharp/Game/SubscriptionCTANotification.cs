using System;
using System.Collections.Generic;
using Game.Shop;
using UnityEngine;
using UnityEngine.Events;

namespace Game
{
	public class SubscriptionCTANotification : MonoBehaviour
	{
		[SerializeField]
		private GameObject _notification;

		[SerializeField]
		private UnityEvent<bool> _onNotificationEvent;

		private List<ShopPackData> _priviledgePacks;

		private PlayerInfo PInfo => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSubscribed(int subscriptionId, TimeSpan duration)
		{
		}

		private void OnSubscriptionDailyClaimed(int subscriptionId)
		{
		}

		private void Check()
		{
		}

		private bool CheckSubscriptionDailyClaimable(int subscriptionId)
		{
			return false;
		}

		private bool CheckShopPackClaimable()
		{
			return false;
		}

		private void SetNotification(bool value)
		{
		}
	}
}
