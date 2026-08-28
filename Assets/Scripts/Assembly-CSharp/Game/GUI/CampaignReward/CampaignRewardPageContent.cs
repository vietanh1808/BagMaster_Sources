using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Combat;
using I2.Loc;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.GUI.CampaignReward
{
	public class CampaignRewardPageContent : UiBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitBagPanel_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public CampaignRewardPageContent _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		private float _bagChangeAnimDuration;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private StandardGameButton _claimButton;

		[SerializeField]
		private CampaignRewardDecorator _decorator;

		[SerializeField]
		private StackingResourceFlyer _flyer;

		public UnityEvent<RewardPack> RewardClaimed;

		[SerializeField]
		private CampaignRewardBagPanel _bagPanel;

		[SerializeField]
		private RewardPanel _rewardPanel;

		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private SkeletonGraphic _backgroundSpine;

		[SerializeField]
		private TMP_Text _chapterText;

		[SerializeField]
		private LocalizationParamsManager _currentChapterParamsManager;

		[SerializeField]
		private LocalizationParamsManager _unlockConditionParamsManager;

		private CampaignDifficultyMode _selectedDifficultyMode;

		private int _currentLevelIndex;

		private LevelData CurrentLevelData => null;

		private bool IsFinalRewardLevel => false;

		private bool IsCurrentRewardClaimable => false;

		private string RewardSourceString => null;

		private static int GetRewardIndex(CampaignDifficultyMode mode)
		{
			return 0;
		}

		private static int GetMaxRewardIndex(CampaignDifficultyMode mode)
		{
			return 0;
		}

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CInitBagPanel_003Ed__26))]
		private UniTaskVoid InitBagPanel()
		{
			return default;
		}

		public void Init(CampaignDifficultyMode mode, in CampaignDifficultyModeSetting setting)
		{
		}

		private void UpdateDifficultyModeSettings(in CampaignDifficultyModeSetting setting)
		{
		}

		private void UpdateBackgroundSpine(in CampaignDifficultyModeSetting setting)
		{
		}

		private void RefreshUi()
		{
		}

		private void UpdateClaimableState(bool isRewardClaimable)
		{
		}

		private void UpdateUnlockCondition(bool isRewardClaimable, int currentLevel, Campaign campaign)
		{
		}

		public void ClaimReward()
		{
		}

		private void ChangeChapter()
		{
		}

		private void FadeInDecorator()
		{
		}

		private void SetInteractable(bool interactable)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
