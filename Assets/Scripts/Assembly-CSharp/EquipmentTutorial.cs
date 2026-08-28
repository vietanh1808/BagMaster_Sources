using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game;
using Game.EquipmentSystem.Inventory;
using Game.GUI;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentTutorial : CustomYieldInstruction
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public UnlockPopup unlockPopup;

		internal bool _003CRun_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CRun_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		public EquipmentTutorial _003C_003E4__this;

		private NavigationHomeButton _003CepmButton_003E5__2;

		private Item _003CfirstItem_003E5__3;

		private InfoPopup _003CinfoPopup_003E5__4;

		private Button _003CeqmRingButton_003E5__5;

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

	public EquipmentTutorial(FTUECanvasManager manager)
	{
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__5))]
	private IEnumerator Run()
	{
		return null;
	}
}
