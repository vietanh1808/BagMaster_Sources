using System.Collections.Generic;
using UnityEngine;

public class DailyRewardReceivePopup : MonoBehaviour
{
	[SerializeField]
	private Transform _rewardSpawnTrans;

	[SerializeField]
	private float _lifeSpan;

	[SerializeField]
	private GameObject _adsButton;

	public void Init(List<DailyRewardIcon> dailyRewardIcons, bool isAds = false)
	{
	}

	public void DestroyPopup()
	{
	}
}
