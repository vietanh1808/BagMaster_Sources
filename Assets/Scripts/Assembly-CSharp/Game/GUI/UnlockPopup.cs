using System;
using System.Collections.Generic;
using Game.AssetManager;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.GUI
{
	public class UnlockPopup : MonoBehaviour
	{
		[SerializeField]
		private Image _background;

		[SerializeField]
		private List<string> _featureDefaultSounds;

		[SerializeField]
		private float _featureUnlockSpeed;

		[SerializeField]
		private float _featureUnlockDelay;

		[SerializeField]
		private float _featureFadeinDuration;

		[SerializeField]
		private GameObject _featureUnlockPopup;

		[SerializeField]
		private Image _featureIcon;

		private Vector2 originalFeatureIconPosition;

		[SerializeField]
		private TextMeshProUGUI _featureName;

		[SerializeField]
		private Button _closeFeatureButton;

		[SerializeField]
		private Image _lockIcon;

		private Vector2 originalLockIconPosition;

		[SerializeField]
		private Sprite[] _lockSprites;

		[SerializeField]
		private ParticleSystem _burstVfx;

		[SerializeField]
		private float _timeScaleLock;

		[SerializeField]
		private List<FeatureUnlockModel> _featureUnlockModels;

		private string _currentFeatureName;

		[SerializeField]
		private float delayLock;

		[SerializeField]
		private GameObject _chapterUnlockPopup;

		[SerializeField]
		private TextMeshProUGUI _chapterTitle;

		[SerializeField]
		private Transform _oldChapterPanel;

		[SerializeField]
		private Transform _newChapterPanel;

		[SerializeField]
		private MMF_Player _unlockChapterFeedback;

		[SerializeField]
		private Button _closeChapterButton;

		[SerializeField]
		private List<Sprite> _chapterIcons;

		[SerializeField]
		private GameObject _chapterUnlockedVFX;

		[SerializeField]
		private PrefabAddressable _chapterIconLoader;

		[SerializeField]
		private Transform _newChapterPosition;

		[SerializeField]
		private PlayDefaultSound playDefaultSound;

		[SerializeField]
		private StringPairCollection _featureNames;

		private List<PopupData> _popupQueue;

		private SpriteAddressable _iconLoader;

		public PopupData currentPopupData;

		private bool _isCurrentlyShowing;

		private bool _isFeatureClosing;

		[SerializeField]
		private bool _isDoneOnce;

		public Action OnClose;

		public bool IsFullyClose => false;

		public bool IsDoneOnce
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void ShowFeatureUnlockPopup(string featureName, bool showFTUE = false, int priority = 0)
		{
		}

		public void ShowEventUnlockPopup(string eventId, string bannerName, Action onClosed, object parameter = null)
		{
		}

		public void ShowFeatureUnlockPopup(string featureName, Sprite icon, bool showFTUE = false, int priority = 0)
		{
		}

		public void ShowFeatureUnlockPopup(string featureName, string iconName, bool showFTUE = false, int priority = 0)
		{
		}

		public void ShowFeatureUnlockPopup(string featureName, string iconName, Transform returnPosition, bool showFTUE = false, int priority = 0)
		{
		}

		public void ShowFeatureUnlockPopup(string featureName, Sprite icon, Transform returnPosition, bool showFTUE = false, int priority = 0)
		{
		}

		private void ProcessQueue()
		{
		}

		public bool IsShowThisPopupFeature(string featureName)
		{
			return false;
		}

		private void CheckAndProcessNext()
		{
		}

		private void ShowFeatureUnlockPopupInternal(string featureName, Sprite icon = null, string iconName = null)
		{
		}

		private Transform GetFeatureIconPosition(string featureName)
		{
			return null;
		}

		private Transform GetFeatureBarIconPos(string featureName)
		{
			return null;
		}

		private FeatureUI GetFeatureUI(string featureName)
		{
			return null;
		}

		public void FeatureClose()
		{
		}

		public void ShowChapterUnlockPopup()
		{
		}

		private void ShowChapterUnlockPopupInternal()
		{
		}

		private void OnChapterIconLoaded(GameObject prefab)
		{
		}

		public void CloseChapterUnlockPopup()
		{
		}

		private Sprite GetChappterIcon(int chapterIndex)
		{
			return null;
		}

		private string GetChapterPrefabPath(int index)
		{
			return null;
		}

		public void ApplyChapterUnlockLogic()
		{
		}

		public void Close()
		{
		}

		public void AddFeaturePopupToQueue(string featureName)
		{
		}

		public void AddChapterPopupToQueue()
		{
		}

		public int GetQueueCount()
		{
			return 0;
		}

		public bool IsCurrentlyShowing()
		{
			return false;
		}

		private void LoadFeatureIcon(string iconName)
		{
		}

		private void PostUpdateFeatureIcon(Sprite sprite)
		{
		}
	}
}
