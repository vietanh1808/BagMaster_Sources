using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.CodedAnimation;
using MoreMountains.Feedbacks;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class VictoryPhase : MonoBehaviour
	{
		[Serializable]
		public class RewardButtonNavigationConfig
		{
			public int ResourceId;

			public GameObject FeatureUiPath;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAcquireRewards_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public VictoryPhase _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CShowRewardReceivedPopup_003Ed__53 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public VictoryPhase _003C_003E4__this;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

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
		protected CurrencyView _rewardItem;

		[SerializeField]
		private string _fpTagObjectNameOnItem;

		[SerializeField]
		protected Button _watchAdsClaimBtn;

		[SerializeField]
		protected Button _normalClaimBtn;

		[SerializeField]
		protected Button _gotoBtn;

		[SerializeField]
		protected Button _homeBtn;

		[SerializeField]
		protected float _rewardItemShowTime;

		[SerializeField]
		protected float _claimBtnShowtime;

		[SerializeField]
		protected float _normalClaimBtnExtraDelay;

		[SerializeField]
		protected string _rewardItemAppearSoundName;

		[SerializeField]
		protected float _adsRewardFlyDuration;

		[SerializeField]
		protected EaseOrAnimationCurve _adsRewardFlyEase;

		[SerializeField]
		protected GameObject _adsRewardFlyHitVfx;

		[SerializeField]
		protected List<RewardButtonNavigationConfig> _conditionalDisplayConfigs;

		[SerializeField]
		protected MMF_Player _openFeedback;

		[SerializeField]
		protected MMAdditiveSceneLoadingManagerSettings _loadingSceneSettings;

		protected RewardPack _rewardPack;

		protected RewardPack _adsReward;

		protected RewardPack _firstRewardToDisplay;

		protected RewardPack _rewardPackToDisplay;

		protected RewardPhase _rewardPhase;

		protected List<CurrencyView> _rewardItemUi;

		protected RewardButtonNavigationConfig _navigationWhenBackHome;

		private int _levelInterOffset;

		protected PlayerInfo PInfo => null;

		protected OwnedResourceEntity ProgressResource => null;

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual void Open()
		{
		}

		protected virtual void ResetUIElements()
		{
		}

		[AsyncStateMachine(typeof(_003CAcquireRewards_003Ed__33))]
		protected virtual UniTaskVoid AcquireRewards()
		{
			return default;
		}

		public void ShowRewards()
		{
		}

		protected virtual void CheckNavigation()
		{
		}

		protected virtual void DetermineFirstReward(int rewardId)
		{
		}

		protected void GetLevelProgressRewardInDisplay()
		{
		}

		protected virtual int DetermineRewardId()
		{
			return 0;
		}

		[Obsolete]
		protected virtual void DetermineRewardGear(int rewardId)
		{
		}

		protected virtual bool ShouldStackFirstRewardToDisplay()
		{
			return false;
		}

		protected virtual bool ShouldStackRewardToDisplay()
		{
			return false;
		}

		protected virtual bool ShouldCombineFirstRewardIntoRewards()
		{
			return false;
		}

		protected virtual void CreateRewardItemUi(ResourceRewardData rs, bool firstReward, int index)
		{
		}

		protected virtual void AddShowInfoRewardItem(ResourceRewardData rewardData, GameObject item)
		{
		}

		protected virtual void DisplayRewards()
		{
		}

		protected virtual int GetFirstRewardsCount()
		{
			return 0;
		}

		protected virtual int GetRewardsCount()
		{
			return 0;
		}

		protected virtual void DisplayClaimButtons()
		{
		}

		protected virtual void ClickNoThanksGoHome()
		{
		}

		protected virtual void ClickGoTo()
		{
		}

		public virtual void GoHome()
		{
		}

		protected virtual void ClickWatchRewardAdsButton()
		{
		}

		[AsyncStateMachine(typeof(_003CShowRewardReceivedPopup_003Ed__53))]
		private UniTaskVoid ShowRewardReceivedPopup()
		{
			return default;
		}

		protected virtual CurrencyView FindRewardItemUi(int resourceId)
		{
			return null;
		}

		private void PlayRewardsFromAdsAnimations()
		{
		}
	}
}
