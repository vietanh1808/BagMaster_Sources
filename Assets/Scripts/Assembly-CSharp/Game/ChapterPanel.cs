using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Game.AssetManager;
using Game.Combat;
using Game.GUI.Chapter;
using MoreMountains.Tools;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Game
{
	public class ChapterPanel : MonoBehaviour
	{
		private const string ChapterIconLabel = "ChapterIcon";

		[CompilerGenerated]
		private static Action<bool> m_onTriggerShowHandAnim;

		private static bool shouldShowHandlickObj;

		[Header("UI")]
		public GameObject ReducedRewardNotification;

		public GameObject ChapterPreview;

		public Transform ChapterPreviewTransform;

		[SerializeField]
		private PrefabAddressable _iconLoader;

		public TextMeshProUGUI ChapterNameTxt;

		public TextMeshProUGUI ChapterRewardProgressTxt;

		public Button PlayBtn;

		public CurrencyView EnergyCostView;

		public Button LeftBtn;

		public Button RightBtn;

		public GameObject LockUi;

		public GameObject[] ShowIfUnlocked;

		public GameObject EnergyPurchasePopup;

		public GameObject BackToLastestBtn;

		public CampaignInfoPanelNoState InfoPanel;

		public EnvironmentEffectview EnvironmentEffectView;

		public FeatureItemPanel FeaturePanel;

		public string ContinueFromDefeatPopupPath;

		[SerializeField]
		private RectTransform _checkpointFlag;

		[SerializeField]
		private GameObject handClickObj;

		[Header("Load Scene")]
		[SerializeField]
		private MMAdditiveSceneLoadingManagerSettings _loadingSceneSettings;

		private bool _isPlaying;

		private Campaign _lastBoundCampaign;

		private AsyncOperationHandle<IList<GameObject>> _chapterIconPreloadHandle;

		[SerializeField]
		private CampaignDifficultySelector _campaignSelector;

		private PlayerInfo PInfo => null;

		private bool IsSelectedChapterLocked => false;

		private static event Action<bool> onTriggerShowHandAnim
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void TriggerShowHandAnim(bool value)
		{
		}

		public Button GetPlayButton()
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void PreloadAllChapterPreview()
		{
		}

		private void OnIconPrefabLoaded(GameObject prefab)
		{
		}

		private void UpdateDifficultyPreview()
		{
		}

		private void ShowHandTutorial(bool value)
		{
		}

		[Obsolete("Use MilestoneRewardCTANotification.UpdateProgress")]
		public void RefreshChapterRewardTxt()
		{
		}

		private void UpdateInfo(Campaign data)
		{
		}

		private void PlayFadeInAnimation()
		{
		}

		private int GetCampaignProgress(int campaignId)
		{
			return 0;
		}

		private void Play()
		{
		}

		private void InitContinueFromDefeat(ContinueFromDefeatPopup popup)
		{
		}

		private void StartPlaying(bool fromStart = true)
		{
		}

		private void TurnLeft()
		{
		}

		private void TurnRight()
		{
		}

		private void SetIndex(int value)
		{
		}

		public void Refresh()
		{
		}

		public void ShowLastest()
		{
		}
	}
}
