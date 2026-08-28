using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Game
{
	public class RewardManager : MonoBehaviour
	{
		private enum State
		{
			Waiting = 0,
			Rewarding = 1,
			RewardPopup = 2
		}

		private struct RewardData
		{
			public string Id;

			public List<ItemDefine> Items;

			public ReceiveRewardsCallBack CompletedCallback;

			public string Placement;

			public bool Claim;

			public bool ShowRewardPopup;

			public string Context;

			public bool IsIap;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			public List<ResourceRewardData> returnRewards;

			internal bool _003CRewardAsync_003Eb__1()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitialize_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public RewardManager _003C_003E4__this;

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
		private struct _003CRewardAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<List<ResourceRewardData>> _003C_003Et__builder;

			public List<ResourceRewardData> rewards;

			public RewardManager _003C_003E4__this;

			public string placement;

			public bool claim;

			public bool showRewardPopup;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

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

		private RewardBundleRewardingService _rewardBundleService;

		private RewardPackRewardingService _rewardPackService;

		private readonly Queue<RewardData> _queue;

		private RewardData _currentReward;

		private State _currentState;

		private int _packItemCount;

		private List<ResourceRewardData> _rewards;

		private bool _initialized;

		public static RewardManager Instance { get; private set; }

		private PlayerInfo PInfo => null;

		public static bool HasInstance()
		{
			return false;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CInitialize_003Ed__20))]
		private UniTask Initialize()
		{
			return default;
		}

		private void OnNewSceneLoaded()
		{
		}

		private void LateUpdate()
		{
		}

		private void LoadPendingReward()
		{
		}

		public void Reward(List<ResourceRewardData> rewards, ReceiveRewardsCallBack completeCallback, string placement, bool claim, bool showRewardPopup, bool isIap = false, string context = "")
		{
		}

		[AsyncStateMachine(typeof(_003CRewardAsync_003Ed__25))]
		public UniTask<List<ResourceRewardData>> RewardAsync(List<ResourceRewardData> rewards, string placement, bool claim, bool showRewardPopup, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		private void StartReward()
		{
		}

		private void ClaimItem(ItemDefine item)
		{
		}

		private void RewardCallback(List<ResourceRewardData> rewarded)
		{
		}

		private bool IsCurrentRewardHandled()
		{
			return false;
		}

		private void CompleteCurrentReward()
		{
		}

		private void NextCycle()
		{
		}
	}
}
