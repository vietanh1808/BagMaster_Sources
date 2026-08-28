using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.GearUpgrade
{
	public class GearCardStarBreakResultItemUI : MonoBehaviour
	{
		[Header("UI References")]
		[SerializeField]
		private Image _characterIcon;

		[SerializeField]
		private Image _shardIcon;

		[SerializeField]
		private Image _progressBarFill;

		[SerializeField]
		private TextMeshProUGUI _itemNameText;

		[SerializeField]
		private TextMeshProUGUI _progressText;

		[SerializeField]
		private TextMeshProUGUI _rewardAmountText;

		[SerializeField]
		private CanvasGroup RewardAmountGroup;

		[SerializeField]
		private GameObject UpgradeableArrow;

		[Header("Animation")]
		[SerializeField]
		private float _delay;

		[SerializeField]
		private float _afterDelay;

		[SerializeField]
		private float _hideRewardAmountGroupDuration;

		[SerializeField]
		private float _speed;

		[SerializeField]
		private float _maxiumDuration;

		[SerializeField]
		private GearIconAndShardProfile _iconAndShardProfileData;

		private void OnDestroy()
		{
		}

		public void UpdateInfo(GearCardStarBreakRewardItem data)
		{
		}
	}
}
