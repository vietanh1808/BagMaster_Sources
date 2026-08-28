using System;
using System.Collections.Generic;
using UnityEngine;

public class DailyRewardManager : MonoBehaviour
{
	[SerializeField]
	private List<DailyRewardSO> dailyRewardSOFull;

	[SerializeField]
	private List<DayRewardUI> dayRewardUI;

	public Action OnPopupClosed;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public DayRewardUI GetFirstDayRewardUI()
	{
		return null;
	}

	private void InitializeDailyRewardsUI()
	{
	}

	private void SetUpDayUI(DayRewardUI ui, DailyRewardSO reward)
	{
	}

	private void UnlockAvailableRewards()
	{
	}

	private void OfferNewbiePack()
	{
	}

	private void OnDestroy()
	{
	}

	public void TurnOffPopup()
	{
	}
}
