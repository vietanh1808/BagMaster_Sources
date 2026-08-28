using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.Combat;

namespace Game.EventDungeon
{
	public class EventDungeonRewardPhase : RewardPhase
	{
		[CompilerGenerated]
		private sealed class _003COpenTraitShops_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EventDungeonRewardPhase _003C_003E4__this;

			private RewardPhaseGearChest _003CrewardPhaseGearChest_003E5__2;

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
			public _003COpenTraitShops_003Ed__6(int _003C_003E1__state)
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

		protected override bool SaveOnRunLogic()
		{
			return false;
		}

		protected override bool ShouldRecoverSaveGame()
		{
			return false;
		}

		protected override bool ShouldReceiveLevelRewards()
		{
			return false;
		}

		protected override bool GetSaveWhenGetTraitItem()
		{
			return false;
		}

		protected override void DetermineRewardGear(LevelData levelData)
		{
		}

		protected override void DetermineUnlockedBuffs()
		{
		}

		[IteratorStateMachine(typeof(_003COpenTraitShops_003Ed__6))]
		protected override IEnumerator OpenTraitShops()
		{
			return null;
		}
	}
}
