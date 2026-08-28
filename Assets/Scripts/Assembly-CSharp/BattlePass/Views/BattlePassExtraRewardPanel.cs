using System;
using System.Collections.Generic;
using Game;
using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.UI;

namespace BattlePass.Views
{
	public class BattlePassExtraRewardPanel : MonoBehaviour
	{
		public static int ORDER_LAYER;

		[SerializeField]
		private ResourceView resourceViewPrefab;

		[SerializeField]
		private GridLayoutGroup gridLayout;

		[SerializeField]
		private MMF_Player player;

		[SerializeField]
		private Button close;

		[SerializeField]
		private Button close2;

		private List<ResourceRewardData> list;

		private List<ResourceView> views;

		private Action onHide;

		private bool canHide;

		private void Awake()
		{
		}

		public void Show(int rewardId, Action hideCallback)
		{
		}

		private void OnDisable()
		{
		}

		private void CanHide()
		{
		}

		public void Hide()
		{
		}
	}
}
