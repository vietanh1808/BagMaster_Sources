using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Game.Combat
{
	public class GearSynercyPhase : IDisposable
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public Dictionary<Gear, int> table;

			public int gearHasBuffCount;

			public int totalGearHasBuff;

			public GearSynercyPhase _003C_003E4__this;

			internal bool _003CInternalRun_003Eb__0(GearStats e)
			{
				return false;
			}

			internal int _003CInternalRun_003Eb__2(GearStats e)
			{
				return 0;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInternalRun_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GearSynercyPhase _003C_003E4__this;

			private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

			private int _003Ccount_003E5__2;

			private int _003CcountFx_003E5__3;

			private IEnumerator<IGrouping<int, GearStats>> _003C_003E7__wrap3;

			private IGrouping<int, GearStats> _003Cgroup_003E5__5;

			private float _003Cdelay_003E5__6;

			private IEnumerator<GearStats> _003C_003E7__wrap6;

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
		private struct _003CPlayHasBuff_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GearStats gearStats;

			public int buffCount;

			public GearSynercyPhase _003C_003E4__this;

			private float _003Cpower_003E5__2;

			private float _003CpowerWithoutBuff_003E5__3;

			private float[] _003Crand_003E5__4;

			private float _003Csum_003E5__5;

			private float _003Cpercent_003E5__6;

			private int _003Ci_003E5__7;

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

		private readonly SynercyPhaseData _data;

		private CancellationTokenSource _cts;

		private IEnumerable<Gear> _gears;

		private List<GearStats> _playedGears;

		private bool _isSkipped;

		private float _currentTextScale;

		private float _currentDelayBetweenBuff;

		private float _currentDelayBetweenGear;

		private Action _onCompleted;

		public GearSynercyPhase(SynercyPhaseData data)
		{
		}

		public void Run(IEnumerable<Gear> gears, Action onCompleted)
		{
		}

		[AsyncStateMachine(typeof(_003CInternalRun_003Ed__11))]
		public UniTask InternalRun()
		{
			return default;
		}

		private void SetupSynercyFloatingText()
		{
		}

		private List<GearStats> SetupGear()
		{
			return null;
		}

		private Dictionary<Gear, int> CreateSynercyTable(Bag bag)
		{
			return null;
		}

		private void PrePlay(GearStats gearStats)
		{
		}

		private void PlayNoBuff(GearStats gearStats)
		{
		}

		[AsyncStateMachine(typeof(_003CPlayHasBuff_003Ed__17))]
		private UniTask PlayHasBuff(GearStats gearStats, int buffCount)
		{
			return default;
		}

		public void Dispose()
		{
		}

		private void CancelToken()
		{
		}
	}
}
