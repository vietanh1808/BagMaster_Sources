using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using Game;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;

public class ArenaRewardItemView : EnhancedScrollerCellView
{
	[SerializeField]
	private MMF_Player feedbackScale;

	[SerializeField]
	private Transform container;

	[SerializeField]
	private TextMeshProUGUI titleText;

	[SerializeField]
	private ResourceView resourceViewPrefab;

	[SerializeField]
	private GameObject indexTop1;

	[SerializeField]
	private GameObject indexTop2;

	[SerializeField]
	private GameObject indexTop3;

	private List<ResourceView> list;

	private static bool isRegisterPool;

	private void Awake()
	{
	}

	public void Init(List<ResourceRewardData> rewards, string title)
	{
	}

	public void OnDisable()
	{
	}

	public void Clear()
	{
	}
}
