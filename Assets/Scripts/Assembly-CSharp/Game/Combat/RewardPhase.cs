using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.CodedAnimation;
using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class RewardPhase : MonoBehaviour
	{
		public enum Phase
		{
			None = 0,
			Enter = 1,
			Gear = 2,
			Buff = 3,
			Exit = 4
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddDropRewardsToWinWave_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public LevelData level;

			public RewardPhase _003C_003E4__this;

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
		private struct _003CCheatReceiveLevelReward_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public RewardPhase _003C_003E4__this;

			public LevelData levelData;

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

		[CompilerGenerated]
		private sealed class _003COpenTraitShop_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardPhase _003C_003E4__this;

			private LevelData _003Clevel_003E5__2;

			private bool _003CsaveWhenGetTraitItem_003E5__3;

			private int _003Ci_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003COpenTraitShop_003Ed__37(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003COpenTraitShops_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardPhase _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003COpenTraitShops_003Ed__36(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReceiveLevelRewards_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public RewardPhase _003C_003E4__this;

			public LevelData level;

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

		[CompilerGenerated]
		private sealed class _003CReceiveStartGears_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LevelData levelData;

			public RewardPhase _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CReceiveStartGears_003Ed__40(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CRunLogic_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardPhase _003C_003E4__this;

			private LevelData _003Clevel_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CRunLogic_003Ed__31(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public RewardPhaseGearChest GearChest;

		public RewardPhaseTraitShop TraitShop;

		public FightPhase FightPhase;

		public GameObject BossIcon;

		public RecyleDropArea Recycle;

		public BenchSlot BenchSlot;

		[Header("CP")]
		public TextMeshProUGUI RecommendCpText;

		public string RecommendCpFormat;

		public float RecommendCpThreshold;

		public Color RecommendCpColor;

		public Color NotRecommendCpColor;

		[Header("Start Gear Animation")]
		[SerializeField]
		private float _appearAnimationDuration;

		[SerializeField]
		private EaseOrAnimationCurve _appearAnimationEase;

		[SerializeField]
		private float _appearAnimationDelay;

		[Header("Runtime")]
		public Phase CurrentPhase;

		public int ReceivedRewardWaveReached { get; private set; }

		public PlayerProfile PlayerProfile => null;

		public Bag Bag => null;

		protected virtual bool ShouldRecoverSaveGame()
		{
			return false;
		}

		protected virtual void RecoverSaveGame()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void Open()
		{
		}

		protected virtual bool SaveOnRunLogic()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CRunLogic_003Ed__31))]
		protected virtual IEnumerator RunLogic()
		{
			return null;
		}

		protected virtual bool ShouldReceiveLevelRewards()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CReceiveLevelRewards_003Ed__33))]
		protected virtual UniTask ReceiveLevelRewards(LevelData level)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CAddDropRewardsToWinWave_003Ed__34))]
		protected UniTask AddDropRewardsToWinWave(LevelData level)
		{
			return default;
		}

		protected virtual float DelayOpenTraitShops()
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003COpenTraitShops_003Ed__36))]
		protected virtual IEnumerator OpenTraitShops()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003COpenTraitShop_003Ed__37))]
		[Obsolete("outdated", true)]
		protected virtual IEnumerator OpenTraitShop()
		{
			return null;
		}

		protected virtual bool GetSaveWhenGetTraitItem()
		{
			return false;
		}

		private void ReceivedStartGold()
		{
		}

		[IteratorStateMachine(typeof(_003CReceiveStartGears_003Ed__40))]
		private IEnumerator ReceiveStartGears(LevelData levelData)
		{
			return null;
		}

		private void ReceiveRecycle(LevelData levelData)
		{
		}

		private void ReceiveBenchCharge(LevelData levelData)
		{
		}

		protected virtual void DetermineRewardGear(LevelData levelData)
		{
		}

		protected virtual void DetermineUnlockedBuffs()
		{
		}

		private void UpdateRecommendCpText()
		{
		}

		private void CreateStartGear(PlayerUnit player, int gearId, Vector2Int position)
		{
		}

		[AsyncStateMachine(typeof(_003CCheatReceiveLevelReward_003Ed__47))]
		public UniTask CheatReceiveLevelReward(LevelData levelData)
		{
			return default;
		}
	}
}
