using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Combat;
using Game.Data;
using UnityEngine;

namespace Game.EventDungeon
{
	public class EventDungeonViewState
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CClaimDropRewards_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<List<ResourceRewardData>> _003C_003Et__builder;

			public EventDungeonViewState _003C_003E4__this;

			public string placement;

			public CancellationToken cancellationToken;

			private List<ResourceRewardData> _003Crewards_003E5__2;

			private float _003Cmultiplier_003E5__3;

			private IEnumerator<LevelData> _003C_003E7__wrap3;

			private UniTask<List<ResourceRewardData>>.Awaiter _003C_003Eu__1;

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
		private struct _003CClaimRewards_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public EventDungeonViewState _003C_003E4__this;

			public CancellationToken cancellationToken;

			private List<ResourceRewardData> _003CshowRewards_003E5__2;

			private UniTask<List<ResourceRewardData>>.Awaiter _003C_003Eu__1;

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
		private struct _003CGetInGameBackgroundTask_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			public EventDungeonViewState _003C_003E4__this;

			private TaskAwaiter<GameObject> _003C_003Eu__1;

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

		public readonly ExcelEventDungeonData item;

		private RewardPack[] levelRewardPacks;

		private RewardPack[] firstLootRewardPacks;

		private Task<GameObject> inGameBackgroundGetTask;

		private RewardPack[] bundleRewardPacks;

		private List<ResourceRewardData> overviewLevelRewards;

		private CancellationTokenSource inGameBackgroundGetCts;

		public EventDungeonViewState(ExcelEventDungeonData item)
		{
		}

		~EventDungeonViewState()
		{
		}

		public void CancelGetInGameBackground()
		{
		}

		public string GetInGameBackgroundPath()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetInGameBackgroundTask_003Ed__11))]
		public Task<GameObject> GetInGameBackgroundTask()
		{
			return null;
		}

		public bool IsChapterUnlocked()
		{
			return false;
		}

		public string GetChapterUnlockContent()
		{
			return null;
		}

		public (float[], int[]) GetLevelGoldDropInfo()
		{
			return default;
		}

		public bool IsLevelCleared()
		{
			return false;
		}

		public RewardPack[] GetFirstLootRewardPacks()
		{
			return null;
		}

		public RewardPack[] GetLevelRewardPacks()
		{
			return null;
		}

		private void UpdateRewardMultiplier(RewardPack[] rewards)
		{
		}

		private bool TryRefreshRewardBoostState(bool isBoosting)
		{
			return false;
		}

		public RewardPack[] GetAllLevelRewardpacks(bool containFirstLoot = false)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CClaimRewards_003Ed__21))]
		public UniTask ClaimRewards(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		public RewardPack[] GetDropBundleRewards()
		{
			return null;
		}

		public List<ResourceRewardData> GetOverviewRewards()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CClaimDropRewards_003Ed__24))]
		public UniTask<List<ResourceRewardData>> ClaimDropRewards(string placement, CancellationToken cancellationToken)
		{
			return default;
		}
	}
}
