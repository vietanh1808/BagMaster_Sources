using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.Combat;
using UnityEngine;

public class Campaign2Tutorial : CustomYieldInstruction
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public RewardPhaseTraitShop traitShop;

		internal bool _003CRun_003Eb__2()
		{
			return false;
		}

		internal bool _003CRun_003Eb__3()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CRun_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Campaign2Tutorial _003C_003E4__this;

		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		private float _003Ctime_003E5__2;

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
		public _003CRun_003Ed__5(int _003C_003E1__state)
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

	private bool isDone;

	private FTUECanvasManager manager;

	public override bool keepWaiting => false;

	public Campaign2Tutorial(FTUECanvasManager manager)
	{
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__5))]
	private IEnumerator Run()
	{
		return null;
	}
}
