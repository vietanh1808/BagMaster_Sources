using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game;
using Game.EventDungeon;
using UnityEngine;

public class DungeonTutorial : CustomYieldInstruction
{
	[CompilerGenerated]
	private sealed class _003CRun_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonTutorial _003C_003E4__this;

		private NavigationHomeButton _003CbattleButton_003E5__2;

		private EventDungeonHandler _003CedHandler_003E5__3;

		private PageEventDungeonListItemBase _003CfirstDungeonItem_003E5__4;

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
		public _003CRun_003Ed__6(int _003C_003E1__state)
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

	private FTUECanvasManager manager;

	private bool isDone;

	private float delayTalentAnimation;

	public override bool keepWaiting => false;

	public DungeonTutorial(FTUECanvasManager manager)
	{
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__6))]
	private IEnumerator Run()
	{
		return null;
	}

	private void GiveEventDungeonTicket()
	{
	}
}
