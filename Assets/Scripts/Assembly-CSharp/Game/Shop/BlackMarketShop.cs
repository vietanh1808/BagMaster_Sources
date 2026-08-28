using System;
using System.Collections.Generic;
using Game.Data;
using TMPro;
using UnityEngine;

namespace Game.Shop
{
	public class BlackMarketShop : ShopByCategory
	{
		[SerializeField]
		private TextMeshProUGUI txtRefreshTime;

		[SerializeField]
		private string format;

		[Header("Refresh Buttons")]
		[SerializeField]
		private BlackMarketRefreshButton _refreshByAdsButton;

		[SerializeField]
		private BlackMarketRefreshButton _refreshCurrencyButton;

		[SerializeField]
		private BlackMarketRefreshButton _refreshLastButton;

		[SerializeField]
		private BlackMarketDisableRefreshButton _refreshDisableButton;

		[SerializeField]
		private TextMeshProUGUI _pigDialogue;

		[Header("Refresh Reveal")]
		[SerializeField]
		private float _flipDelayPerItem;

		public const int MaxRefreshCount = 4;

		private Coroutine coroutine;

		private readonly List<BlackMarketShopData> _resolvedRows;

		private double _refreshCountdownSeconds;

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		private void SetupRefreshButtons()
		{
		}

		private void OnAnItemClaimed(BlackMarketPackShopItem shopItem, ShopPackData shopData)
		{
		}

		private void AutoTick()
		{
		}

		private void RefreshAll(bool shouldRefresh = false, bool lastTurn = false)
		{
		}

		private int ResolveRows(List<LogPurchaseShopPackData> packLogs, int count)
		{
			return 0;
		}

		private void ApplyShopItems(List<LogPurchaseShopPackData> packLogs, int count, int mostDealIndex, bool shouldFaceDown)
		{
		}

		private void PlayRevealAnimation()
		{
		}

		private void Refresh(BlackMarketPackShopItem shopItem, LogPurchaseShopPackData logData)
		{
		}

		private void CheckInternetConnection(bool isConnected)
		{
		}

		private void CheckUnlockAnyPack()
		{
		}

		private List<BlackMarketShopData> RandomPicked()
		{
			return null;
		}

		private List<BlackMarketShopData> RandomPickedWithMostDeal()
		{
			return null;
		}

		private static bool IsInPastCycle(DateTime lastTime, DateTime now)
		{
			return false;
		}

		private void EnsureRefreshCountFresh()
		{
		}

		private void UpdateRefreshButtons()
		{
		}

		private void UpdateDisableCountdownText()
		{
		}

		private bool TryGetRefreshCost(int used, out ResourceRequireData cost)
		{
			cost = null;
			return false;
		}

		private List<ResourceRequireData> GetRefreshCostList()
		{
			return null;
		}

		private void DoManualRefresh(bool isLast)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
