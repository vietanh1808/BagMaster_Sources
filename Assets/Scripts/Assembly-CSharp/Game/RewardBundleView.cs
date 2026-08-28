using System.Collections.Generic;
using Game.RewardBundle;
using I2.Loc;
using UnityEngine;
using UnityEngine.Events;

namespace Game
{
	public class RewardBundleView : MonoBehaviour
	{
		[SerializeField]
		private Localize _bundleNameText;

		[SerializeField]
		private ResourceView _bundleView;

		[SerializeField]
		private Localize _selectionCountText;

		[SerializeField]
		private List<RewardBundleRewardItem> _items;

		[Header("Events")]
		public UnityEvent OnUpdateInfoEvent;

		private RewardBundleData _bundleData;

		private int _amount;

		public IReadOnlyCollection<RewardBundleRewardItem> Items => null;

		public int Amount => 0;

		public void UpdateInfo(RewardBundleData bundleData, int amount)
		{
		}
	}
}
