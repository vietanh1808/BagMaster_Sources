using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.RewardBundle
{
	[RequireComponent(typeof(RewardBundleView))]
	public class RewardBundlePlayerChoice : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _selectionCountText;

		[SerializeField]
		private Button _claimButton;

		[SerializeField]
		private Button _notEnoughButton;

		private RewardBundleView _bundleView;

		private ReceiveRewardsCallBack _onClaimed;

		private List<RewardBundleRewardItem> _selectedItems;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateInfo()
		{
		}

		public void SetOnclaimedCallback(ReceiveRewardsCallBack callBack)
		{
		}

		private void OnItemClicked(RewardBundleRewardItem item)
		{
		}

		private void RefreshButtons()
		{
		}

		private void OnClaimClicked()
		{
		}

		private void OnNotEnoughClicked()
		{
		}
	}
}
