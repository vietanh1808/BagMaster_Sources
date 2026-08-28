using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public class SubscriptionPackItem : TimePackShopItem
	{
		[Header("Subscription")]
		[SerializeField]
		private Button _renewButton;

		[SerializeField]
		private TextMeshProUGUI _renewPriceText;

		[SerializeField]
		[Tooltip("Use When has discount")]
		protected TextMeshProUGUI _renewOriginalPriceText;

		[SerializeField]
		private TextMeshProUGUI _durationText;

		[SerializeField]
		private TextMeshProUGUI _remainDurationText;

		[SerializeField]
		private GameObject _inDurationObject;

		[SerializeField]
		private bool _deactivePurchaseButtonInDuration;

		[SerializeField]
		private int _changeRemainDayThresold;

		[SerializeField]
		private Color _changeRemainDayColorNormal;

		[SerializeField]
		private Color _changeRemainDayColorThresold;

		private TimeSpan _remainDuration;

		private PlayerInfo PInfo => null;

		public bool IsSubscribed => false;

		public bool IsRenewable => false;

		protected override void Start()
		{
		}

		private void OnEnable()
		{
		}

		public override void Initialize(ShopPackData package)
		{
		}

		protected override void UpdateButtons()
		{
		}

		protected override void UpdateIapButton()
		{
		}

		protected override TextMeshProUGUI GetOriginalPriceText()
		{
			return null;
		}

		protected override void RefreshAfterClaim()
		{
		}

		private void UpdateRemainDuration(ShopPackData shopPackData)
		{
		}

		private void UpdateInDurationObject()
		{
		}

		public void RefreshUi()
		{
		}

		public void Renew()
		{
		}
	}
}
