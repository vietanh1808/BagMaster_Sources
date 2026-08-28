using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.Combat;
using UnityEngine;
using UnityEngine.UI;

public class GameLegendSwordMergeStep : CustomYieldInstruction
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public GameLegendSwordMergeStep _003C_003E4__this;

		public GearLevel5Popup popup;

		public int legendSwordId;

		public Func<Gear, bool> _003C_003E9__3;

		internal void _003CRun_003Eb__1()
		{
		}

		internal bool _003CRun_003Eb__2()
		{
			return false;
		}

		internal bool _003CRun_003Eb__3(Gear g)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public Gear rareSword;

		public Transform gearHolder;

		internal void _003CGiveRareSword_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGiveRareSword_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLegendSwordMergeStep _003C_003E4__this;

		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		private IEnumerable<Gear> _003Cgears_003E5__2;

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
		public _003CGiveRareSword_003Ed__9(int _003C_003E1__state)
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
	private sealed class _003CRun_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLegendSwordMergeStep _003C_003E4__this;

		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

		private Button _003CstartButton_003E5__2;

		private Button.ButtonClickedEvent _003CstartButtonEvent_003E5__3;

		private int _003CepicSwordId_003E5__4;

		private GameObject _003Cepic1_003E5__5;

		private GameObject _003Cepic2_003E5__6;

		private bool _003CalreadyMerged_003E5__7;

		private WorldUI _003CworldUI_003E5__8;

		private RectTransform _003CrectTransform_003E5__9;

		private bool _003CshowingStartHand_003E5__10;

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
		public _003CRun_003Ed__7(int _003C_003E1__state)
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

	private GameObject pig;

	private PigAnimationConfig pigAnimConfig;

	public override bool keepWaiting => false;

	public GameLegendSwordMergeStep(FTUECanvasManager manager)
	{
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__7))]
	private IEnumerator Run()
	{
		return null;
	}

	private (GameObject, GameObject) SwapIfThereIsInBag(GameObject firstItem, GameObject secondItem)
	{
		return default;
	}

	[IteratorStateMachine(typeof(_003CGiveRareSword_003Ed__9))]
	private IEnumerator GiveRareSword()
	{
		return null;
	}
}
