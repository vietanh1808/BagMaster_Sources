using Game.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.GearUpgrade
{
	public class GearUIItem : MonoBehaviour
	{
		[Header("General")]
		[SerializeField]
		private Image _icon;

		[SerializeField]
		private Image _silhouetteIcon;

		[SerializeField]
		private Color _lockedColor;

		[SerializeField]
		private TextMeshProUGUI _nameText;

		[SerializeField]
		private Animator _animator;

		[SerializeField]
		private GameObject _notification;

		[Header("Tags")]
		[SerializeField]
		private GearTagIconProfile _gearTagIconProfile;

		[SerializeField]
		private Image _elementalImage;

		[Header("Flags")]
		[SerializeField]
		private ElementalSpriteData _flagDatas;

		[SerializeField]
		private Image _elementalFlagImage;

		[Header("Upgrade")]
		[SerializeField]
		private Image _upgradeProgressContent;

		[SerializeField]
		private TextMeshProUGUI _upgradeProgressText;

		[SerializeField]
		private TextMeshProUGUI _levelUpgradedText;

		[SerializeField]
		private string _levelUpgradeTextFormat;

		[SerializeField]
		private GameObject _upgradeableArrow;

		[SerializeField]
		private Image _elementalFlag;

		[SerializeField]
		private Image _gearShardIcon;

		[Header("Stars")]
		[SerializeField]
		private GameObject[] _stars;

		[SerializeField]
		private Image _tierImage;

		[SerializeField]
		private GearUITierUiProfile _tierUiProfile;

		[Header("Unlock")]
		[SerializeField]
		private GameObject _unlocked;

		[SerializeField]
		private GameObject _locked;

		[SerializeField]
		private TextMeshProUGUI _unlockConditionText;

		[SerializeField]
		private string _unlockConditionTextFormat;

		[SerializeField]
		private string _unknownConditionTextFormat;

		[Header("Info")]
		[SerializeField]
		private Button _showInfoPopupButton;

		[SerializeField]
		private bool _listenResourceChanges;

		private PlayerInfo _playerInfo;

		private GearData _gearData;

		private int _currentLevel;

		private GearUpgradeData _gearUpgradeData;

		private bool _isUnlocked;

		private bool _isMax;

		public PlayerInfo PInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool IsUpgradable => false;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnResourceChanged(OwnedResourceEntity entity, int arg2)
		{
		}

		public void UpdateInfo(GearData gearData)
		{
		}

		private void UpdateTags()
		{
		}

		private void UpdateFlag()
		{
		}

		public void RefreshLevel()
		{
		}

		public void RefreshProgress()
		{
		}

		public void UpdateStars()
		{
		}

		public void UpdateLockStatus()
		{
		}

		public int GetShardTier()
		{
			return 0;
		}

		public int GetRequireCards()
		{
			return 0;
		}

		public string GetRequireSprite()
		{
			return null;
		}

		public int GetOwnedCards()
		{
			return 0;
		}

		public bool IsUnlocked()
		{
			return false;
		}

		public void SetCTANotification(bool show)
		{
		}

		public void RefreshCTANotification()
		{
		}
	}
}
