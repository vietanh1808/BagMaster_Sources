using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Newbie
{
	public class NewbieDailyItem : MonoBehaviour
	{
		[Serializable]
		private class DailyData
		{
			public NewbieTabType tab;

			public Sprite spriteBorder;

			public Sprite spriteCardTop;

			public Sprite spriteCardBodyClaimable;

			public Sprite spriteCardTopClaimable;

			public Sprite spriteBackGlow;
		}

		[SerializeField]
		private ResourceView[] views;

		[SerializeField]
		private DailyData[] dailyData;

		[SerializeField]
		private Image imgBorder;

		[Header("Newbie Daily Reward UI")]
		[SerializeField]
		private GameObject lockObject;

		[SerializeField]
		private GameObject claimableRewardBG;

		[SerializeField]
		private Button claimableRewardButton;

		[SerializeField]
		private GameObject claimedRewardBG;

		[SerializeField]
		private GameObject comeBackTimerBG;

		[SerializeField]
		private TextMeshProUGUI comeBackText;

		[SerializeField]
		private Color comBackTextColor;

		[Header("Normal Daily Reward UI")]
		[SerializeField]
		private Image imgCardTop;

		[Header("Claimable Reward UI")]
		[SerializeField]
		private Image imgCardBodyClaimable;

		[SerializeField]
		private Image imgCardTopClaimable;

		[SerializeField]
		private Image imageBackGlow;

		private Action OnClaimReward;

		private List<ResourceView> _viewList;

		private NewbieData _data;

		private int _day;

		private Action _onUnlocked;

		private bool _timerRunning;

		private void Awake()
		{
		}

		public void Initialize(NewbieTabType newbieTabType, List<ResourceRewardData> rewards, ResourcesState state, NewbieData data, int day, Action onClaimReward, Action onUnlocked)
		{
		}

		private void ClickItem()
		{
		}

		private void Update()
		{
		}

		private void UpdateComeBackTimer()
		{
		}

		private bool RefreshComeBackText()
		{
			return false;
		}

		private static string FormatRemainSingeTime(long seconds)
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
