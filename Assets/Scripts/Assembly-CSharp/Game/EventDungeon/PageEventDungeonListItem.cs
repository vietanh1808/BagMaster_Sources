using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EventDungeon
{
	public class PageEventDungeonListItem : PageEventDungeonListItemBase
	{
		[Serializable]
		public class OverlayColor
		{
			public EventDungeonType type;

			public Color color;
		}

		[SerializeField]
		private Button buttonEnter;

		[SerializeField]
		private TMP_Text textName;

		[SerializeField]
		private TMP_Text textFloor;

		[SerializeField]
		private Image imageBanner;

		[SerializeField]
		private TMP_Text textDifficult;

		[SerializeField]
		private GameObject chanceLeftObj;

		[SerializeField]
		private TMP_Text textChancesLeft;

		[SerializeField]
		private Image imageTicketIcon;

		[SerializeField]
		private Transform contentReward;

		[SerializeField]
		private CurrencyView itemPrefab;

		private List<CurrencyView> rewardItems;

		[SerializeField]
		private GameObject lockObject;

		[SerializeField]
		private TMP_Text textLockContent;

		[SerializeField]
		private GameObject objectNotification;

		[SerializeField]
		private GameObject objectNotificationGreen;

		[SerializeField]
		private TMP_Text objectNotificationGreenText;

		[SerializeField]
		private OverlayColor[] overlayColors;

		[SerializeField]
		private Image[] imageOverlays;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnTicketChanged(EventDungeonUnlockViewState state)
		{
		}

		protected override void OnTriggerRefresh()
		{
		}

		public override void RenderView(EventDungeonUnlockViewState data)
		{
		}

		private void SettingNotification(EventDungeonUnlockViewState data)
		{
		}

		private void UpdateOverlayImages(EventDungeonUnlockViewState data)
		{
		}

		private void UpdateRewardContent(EventDungeonUnlockViewState data)
		{
		}

		public void RefreshRewardContentView(List<ResourceRewardData> rewards, List<ResourceRewardData> firstLootReward)
		{
		}

		private void CreateOrResuseRewardItem(int i, Transform content, ResourceRewardData reward, bool showFirstReward = false)
		{
		}

		[Obsolete]
		private void RefreshRewardContentView(List<ResourceRewardData> rewards)
		{
		}

		private void OnItemClicked()
		{
		}

		public override void PlayActiveFeedback()
		{
		}
	}
}
