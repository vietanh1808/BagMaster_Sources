using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.EventDungeon
{
	public class EventDungeonInfoRewardsLayout : MonoBehaviour
	{
		[SerializeField]
		private GameObject scrollRectObj;

		[SerializeField]
		private RectTransform scrollableContent;

		[SerializeField]
		private RectTransform noScrollContent;

		[SerializeField]
		private CurrencyView itemPrefab;

		private readonly List<CurrencyView> listItems;

		public void SetData(List<ResourceRewardData> rewards, List<ResourceRewardData> firstLootReward)
		{
		}

		private void CreateOrResuseRewardItem(int i, RectTransform content, ResourceRewardData reward, bool showFirstReward = false)
		{
		}

		[Obsolete]
		public void SetData(List<ResourceRewardData> rewards)
		{
		}
	}
}
