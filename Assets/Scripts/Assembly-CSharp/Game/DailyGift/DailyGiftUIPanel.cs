using System;
using System.Collections.Generic;
using Game.Data;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

namespace Game.DailyGift
{
	public class DailyGiftUIPanel : MonoBehaviour
	{
		[SerializeField]
		private List<DailyGiftUIItem> _items;

		[SerializeField]
		private LocalizationParamsManager _timerText;

		[SerializeField]
		private Image _progressContent;

		[SerializeField]
		private float[] _progresses;

		private DailyGiftService _dailyGiftService;

		private bool _dirty;

		private IDisposable _timer;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		public void Refresh()
		{
		}

		private void RefreshProgress(IReadOnlyCollection<DailyGiftDisplayData> listGifts)
		{
		}

		private void OnItemWatchAds(DailyGiftUIItem displayItem)
		{
		}

		private void OnItemClaimRequested(DailyGiftUIItem displayItem)
		{
		}

		private void OnServiceWatchAdsSuccessful(DailyGiftData data, bool useTicket)
		{
		}

		private void OnServiceClaimSuccessful(DailyGiftData data)
		{
		}

		private void UpdateTimer()
		{
		}
	}
}
