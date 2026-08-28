using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.Combat;
using UnityEngine;

public class GiveRareSwordStep : CustomYieldInstruction
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public Gear rareSword;

		public Transform gearHolder;

		internal void _003CRun_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRun_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GiveRareSwordStep _003C_003E4__this;

		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		private PigAnimationConfig _003CpigAnimConfig_003E5__2;

		private IEnumerable<Gear> _003Cgears_003E5__3;

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

	public GiveRareSwordStep(FTUECanvasManager manager)
	{
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__5))]
	private IEnumerator Run()
	{
		return null;
	}
}
