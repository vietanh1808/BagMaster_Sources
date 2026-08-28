using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.Combat;
using UnityEngine;
using UnityEngine.UI;

public class GameEpicSwordMergeStep : CustomYieldInstruction
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public int epicSwordId;

		public Predicate<Gear> _003C_003E9__0;

		internal bool _003CRun_003Eb__0(Gear gear)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public int rareSwordId;

		public int unCommonSwordId;

		public int commonSwordId;

		internal bool _003CMergeUntilHaveEpicSword_003Eb__1(Gear g)
		{
			return false;
		}

		internal bool _003CMergeUntilHaveEpicSword_003Eb__2(Gear g)
		{
			return false;
		}

		internal bool _003CMergeUntilHaveEpicSword_003Eb__3(Gear g)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CMergeUntilHaveEpicSword_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool showText;

		public GameEpicSwordMergeStep _003C_003E4__this;

		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

		private int _003CepicSwordId_003E5__2;

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
		public _003CMergeUntilHaveEpicSword_003Ed__7(int _003C_003E1__state)
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
	private sealed class _003CRun_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameEpicSwordMergeStep _003C_003E4__this;

		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		private Button _003CstartButton_003E5__2;

		private Button.ButtonClickedEvent _003CstartButtonEvent_003E5__3;

		private Coroutine _003CmergeCoroutine_003E5__4;

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

	[CompilerGenerated]
	private sealed class _003CWaitPlayerMergeItem_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameEpicSwordMergeStep _003C_003E4__this;

		public GameObject firstItem;

		public GameObject secondItem;

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
		public _003CWaitPlayerMergeItem_003Ed__8(int _003C_003E1__state)
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

	public GameEpicSwordMergeStep(FTUECanvasManager manager)
	{
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__5))]
	private IEnumerator Run()
	{
		return null;
	}

	private List<Gear> GetAvailableGears()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMergeUntilHaveEpicSword_003Ed__7))]
	private IEnumerator MergeUntilHaveEpicSword(bool showText = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitPlayerMergeItem_003Ed__8))]
	private IEnumerator WaitPlayerMergeItem(GameObject firstItem, GameObject secondItem)
	{
		return null;
	}
}
