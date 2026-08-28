using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game;

public static class PendingRewardService
{
	[Serializable]
	private class PendingRewardData
	{
		[Serializable]
		public class PendingRewardEntry
		{
			[Serializable]
			public class PendingRewardItem
			{
				public int id;

				public int value;
			}

			public int packId;

			public bool deliveryToBar;

			public List<PendingRewardItem> items;
		}

		public List<PendingRewardEntry> entries;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CFlushSave_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CShowPendingRewardsAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public Func<bool> isPageReady;

		public CancellationToken ct;

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

	private static readonly Queue<(RewardPack rewardPack, Action onClose, bool deliveryToBar)> _pendingRewards;

	private static bool _saveDirty;

	private const string PrefsKey = "iap_pending_rewards";

	public static void QueueReward(RewardPack rewardPack, Action onClose, bool deliveryToBar)
	{
	}

	[AsyncStateMachine(typeof(_003CShowPendingRewardsAsync_003Ed__5))]
	public static UniTask ShowPendingRewardsAsync(Func<bool> isPageReady, CancellationToken ct)
	{
		return default;
	}

	private static void ScheduleSave()
	{
	}

	[AsyncStateMachine(typeof(_003CFlushSave_003Ed__7))]
	private static UniTaskVoid FlushSave()
	{
		return default;
	}

	private static void SaveToPrefs()
	{
	}

	private static void LoadFromPrefs()
	{
	}
}
