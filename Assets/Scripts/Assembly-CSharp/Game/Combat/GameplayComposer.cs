using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Combat.Dungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Game.Combat
{
	[DefaultExecutionOrder(-10)]
	public class GameplayComposer : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDelayRemovePlayer_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int playerId;

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
		protected BagLayoutManager _bagLayoutManager;

		[SerializeField]
		protected BagNewSlotManager _bagNewSlotManager;

		[SerializeField]
		protected GameplayBagSaveInitializer _bagSaveInitializer;

		[SerializeField]
		protected GameplayBagInitializer _bagInitializer;

		[SerializeField]
		protected Bag _bag;

		[SerializeField]
		protected GameplayGearManager _gameplayGearManager;

		[SerializeField]
		protected RecyleDropArea _recycleDropArea;

		[SerializeField]
		protected CounterDropArea _counterDropArea;

		[SerializeField]
		protected BenchDropArea _benchDropArea;

		[SerializeField]
		protected GearLuckyEffectSpawner _gearLuckEffectSpawner;

		[SerializeField]
		protected GearSynercyEffectManager _gearSynercyEffectManager;

		[SerializeField]
		protected ExpManager ExpManager;

		private IMergeService _itemMergeService;

		private Unit _player;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void InitializePlayers()
		{
		}

		[AsyncStateMachine(typeof(_003CDelayRemovePlayer_003Ed__18))]
		private static UniTask DelayRemovePlayer(int playerId)
		{
			return default;
		}

		protected IMergeService CreateGearMergeService()
		{
			return null;
		}
	}
}
