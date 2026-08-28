using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class EventDungeonVictoryPhase : VictoryPhase
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAcquireRewards_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public EventDungeonVictoryPhase _003C_003E4__this;

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
		private struct _003CClaimDropBundleRewards_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public EventDungeonVictoryPhase _003C_003E4__this;

			private UniTask<System.Collections.Generic.List<ResourceRewardData>>.Awaiter _003C_003Eu__1;

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
		private struct _003CDisplayRewards_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public EventDungeonVictoryPhase _003C_003E4__this;

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
		private Button buttonHome;

		[SerializeField]
		private Button buttonHomeAlt;

		[SerializeField]
		private Button buttonNextLevel;

		[SerializeField]
		private ScrollRect scrollRectRewards;

		[SerializeField]
		private float scrollToBottomDelay;

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void ResetUIElements()
		{
		}

		public override void Open()
		{
		}

		[AsyncStateMachine(typeof(_003CAcquireRewards_003Ed__9))]
		protected override UniTaskVoid AcquireRewards()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CClaimDropBundleRewards_003Ed__10))]
		private UniTask ClaimDropBundleRewards()
		{
			return default;
		}

		protected override void DetermineFirstReward(int rewardId)
		{
		}

		private void ReduceTicket()
		{
		}

		protected override int DetermineRewardId()
		{
			return 0;
		}

		protected void ClaimRewards()
		{
		}

		protected override void DisplayClaimButtons()
		{
		}

		[AsyncStateMachine(typeof(_003CDisplayRewards_003Ed__16))]
		protected override void DisplayRewards()
		{
		}

		protected override void ClickNoThanksGoHome()
		{
		}

		protected override void ClickWatchRewardAdsButton()
		{
		}

		private void OnHomeClicked()
		{
		}

		private void OnNextLevelClicked()
		{
		}
	}
}
