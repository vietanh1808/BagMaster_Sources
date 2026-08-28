using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Inventory
{
	public class Item : EquipmentInfo
	{
		[Header("UI References")]
		[SerializeField]
		private EquipmentInfoGeneralUI _generalUI;

		[SerializeField]
		private GameObject _notificationUI;

		[SerializeField]
		private MMF_Player _equipFeedback;

		[Header("Upgrade Noti")]
		[SerializeField]
		private bool _checkShowNotiUpgradable;

		[SerializeField]
		private Image _notiBgImg;

		[SerializeField]
		private Sprite _upgradeNotiSprite;

		[SerializeField]
		private Sprite _equipNotiSprite;

		[SerializeField]
		private Sprite _swapEquipNotiSprite;

		[SerializeField]
		private bool _doNotCheckUpgrade;

		[SerializeField]
		private bool _doNothing;

		[Header("UI Data")]
		[SerializeField]
		private EquipmentPartVisualData _partVisualData;

		[SerializeField]
		private EquipmentInfoRarityData _rarityData;

		private EquipmentLevelData _currentLevelData;

		private int _maxLevel;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEquipmentLevelChanged(int levelId, int newLevel)
		{
		}

		protected override void UpdateInfo()
		{
		}

		private void UpdateLevelData(EquipmentUpgradeData upgradeData, int level)
		{
		}

		private void UpdateUI()
		{
		}

		public void SetNotification(bool show, bool isSwap)
		{
		}

		private void CheckShowNotiUpgradable()
		{
		}

		private bool CanUpgrade()
		{
			return false;
		}

		public void PlayEquipFeedback()
		{
		}

		public void ShowInfoPopup()
		{
		}
	}
}
