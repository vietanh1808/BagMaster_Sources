using System;
using System.Collections.Generic;
using DG.Tweening;
using DoorServices;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace Game.Newbie
{
	public class NewbiePopup : MonoBehaviour, IIapOfferView
	{
		[Serializable]
		private class Data
		{
			public NewbieTabType tab;

			public Button button;

			public TextMeshProUGUI textPrice;

			public Sprite spriteGlow;

			public Sprite spriteBackground;

			public Sprite spriteRibbon;

			public GameObject notificationObj;
		}

		private readonly struct ClaimableRewardEntry
		{
			public readonly NewbieData Data;

			public readonly int Day;

			public readonly RewardPack RewardPack;

			public ClaimableRewardEntry(NewbieData data, int day, RewardPack rewardPack)
			{
				Data = null;
				Day = 0;
				RewardPack = null;
			}
		}

		[SerializeField]
		private Image imgGlow;

		[SerializeField]
		private Image imgBackground;

		[SerializeField]
		private Image imgRibbon;

		[SerializeField]
		private TextMeshProUGUI textDescription;

		[SerializeField]
		private Transform behindButtonContainer;

		[SerializeField]
		private Transform frontButtonContainer;

		[SerializeField]
		private Button buttonPurchase;

		[SerializeField]
		private Button buttonPurchased;

		[SerializeField]
		private TextMeshProUGUI textPricePurchase;

		[SerializeField]
		private NewbieDailyItem[] dailyItems;

		[SerializeField]
		private Data[] datas;

		[Header("Returning animation")]
		[SerializeField]
		private MMF_Player openFeedback;

		[SerializeField]
		private MMF_Player returnFeedback;

		[SerializeField]
		private Transform container;

		[SerializeField]
		private float returnDuration;

		[SerializeField]
		private Ease returnEase;

		[SerializeField]
		private GameObject endReturnVfx;

		private NewbieTabType currentTab;

		private bool canHide;

		public Action OnClosed;

		private bool isFirstOpen;

		private string productId;

		[Header("Claim All")]
		[SerializeField]
		private Button buttonClaimAll;

		private readonly List<ClaimableRewardEntry> _claimableEntries;

		public string IapProductId => null;

		public StoreEntryMethod StoreEntryMethod { get; set; }

		private void Awake()
		{
		}

		private void Purchase()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ShowDefault()
		{
		}

		public void ActiveTab(NewbieTabType tab)
		{
		}

		private void UpdateRemainRewardInTab(Data[] data)
		{
		}

		private void UpdatePurchasedPack()
		{
		}

		private void ClaimAll()
		{
		}

		private NewbieTabType GetNextTabAfterClaimAll()
		{
			return NewbieTabType.Tab1;
		}

		private void UpdateClaimAllButton()
		{
		}

		public void ReturnNClose()
		{
		}

		private void Close()
		{
		}

		private void OnPurchaseSuccess(Order order)
		{
		}

		public void CanHide()
		{
		}
	}
}
