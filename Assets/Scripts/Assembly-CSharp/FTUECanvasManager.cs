using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Game;
using Game.Combat;
using MoreMountains.Tools;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class FTUECanvasManager : MonoBehaviour
{
	public enum BGType
	{
		Transparent = 0,
		Dark = 1,
		Off = 2
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public FTUECanvasManager _003C_003E4__this;

		public Gear counterGear;

		public Func<Gear, bool> _003C_003E9__8;

		internal bool _003CFTUE_InGame_1_2Coroutine_003Eb__3(Gear gear)
		{
			return false;
		}

		internal bool _003CFTUE_InGame_1_2Coroutine_003Eb__4(Gear g)
		{
			return false;
		}

		internal bool _003CFTUE_InGame_1_2Coroutine_003Eb__8(Gear otherGear)
		{
			return false;
		}

		internal void _003CFTUE_InGame_1_2Coroutine_003Eb__5()
		{
		}

		internal bool _003CFTUE_InGame_1_2Coroutine_003Eb__10()
		{
			return false;
		}

		internal bool _003CFTUE_InGame_1_2Coroutine_003Eb__6()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CContinuousAlphaLerp_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CContinuousAlphaLerp_003Ed__64(int _003C_003E1__state)
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
	private sealed class _003CFTUE_First_CutSceneCoroutine_003Ed__144 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CFTUE_First_CutSceneCoroutine_003Ed__144(int _003C_003E1__state)
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
	private sealed class _003CFTUE_InGame_1Coroutine_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

		private GoldBar _003Cgoldbar_003E5__2;

		private WorldUI _003CworldUI_003E5__3;

		private Transform _003ClastItem_003E5__4;

		private bool _003CtrackedPlaceGear_003E5__5;

		private Sequence _003Csequence_003E5__6;

		private bool _003CisDragging_003E5__7;

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
		public _003CFTUE_InGame_1Coroutine_003Ed__66(int _003C_003E1__state)
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
	private sealed class _003CFTUE_InGame_1_2Coroutine_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass72_0 _003C_003E8__1;

		private WorldUI _003CworldUI_003E5__2;

		private GameObject _003CsecondItem_003E5__3;

		private Sequence _003Csequence_003E5__4;

		private bool _003CshowDragging_003E5__5;

		private bool _003CshouldShowHand_003E5__6;

		private Gear _003CfirstGear_003E5__7;

		private Gear _003CsecondGear_003E5__8;

		private Sequence _003ChandSequence_003E5__9;

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
		public _003CFTUE_InGame_1_2Coroutine_003Ed__72(int _003C_003E1__state)
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
	private sealed class _003CFTUE_InGame_1_3Coroutine_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

		private WorldUI _003CworldUI_003E5__2;

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
		public _003CFTUE_InGame_1_3Coroutine_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CFTUE_InGame_1_4Coroutine_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

		private WorldUI _003CworldUI_003E5__2;

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
		public _003CFTUE_InGame_1_4Coroutine_003Ed__78(int _003C_003E1__state)
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
	private sealed class _003CFadingWhenActionTextBox_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CFadingWhenActionTextBox_003Ed__63(int _003C_003E1__state)
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
	private sealed class _003CForceMoveGearToBag_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

		public Gear gear;

		private Square _003Cslot_003E5__2;

		private bool _003CshouldShowHand_003E5__3;

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
		public _003CForceMoveGearToBag_003Ed__80(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CHideTapHintAfterDelay_003Ed__113 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CHideTapHintAfterDelay_003Ed__113(int _003C_003E1__state)
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
	private sealed class _003CHighlightItemWhenIdle_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003Celapsed_003E5__2;

		private bool _003Cflag_003E5__3;

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
		public _003CHighlightItemWhenIdle_003Ed__89(int _003C_003E1__state)
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
	private sealed class _003CIntroduceFunctionSlots_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CIntroduceFunctionSlots_003Ed__86(int _003C_003E1__state)
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
	private sealed class _003CIntroduceSkills_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CIntroduceSkills_003Ed__116(int _003C_003E1__state)
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
	private sealed class _003CIntroduceStows_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CIntroduceStows_003Ed__87(int _003C_003E1__state)
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
	private sealed class _003CPlayVideoCoroutine_003Ed__143 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CPlayVideoCoroutine_003Ed__143(int _003C_003E1__state)
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
	private sealed class _003CShow7DayTutorial_003Ed__155 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CShow7DayTutorial_003Ed__155(int _003C_003E1__state)
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
	private sealed class _003CShowDungeonTutorial_003Ed__154 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CShowDungeonTutorial_003Ed__154(int _003C_003E1__state)
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
	private sealed class _003CShowDungeonTutorialAfterDelay_003Ed__142 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CShowDungeonTutorialAfterDelay_003Ed__142(int _003C_003E1__state)
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
	private sealed class _003CShowEquipmentTutorial_003Ed__151 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CShowEquipmentTutorial_003Ed__151(int _003C_003E1__state)
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
	private sealed class _003CShowTalentTutorial_003Ed__153 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CShowTalentTutorial_003Ed__153(int _003C_003E1__state)
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
	private sealed class _003CTestTapInBottomRightCoroutine_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CTestTapInBottomRightCoroutine_003Ed__111(int _003C_003E1__state)
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
	private sealed class _003CTestTapOnGearCoroutine_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int gearIndex;

		public FTUECanvasManager _003C_003E4__this;

		private GameObject _003CgearObject_003E5__2;

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
		public _003CTestTapOnGearCoroutine_003Ed__109(int _003C_003E1__state)
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
	private sealed class _003CWaitBuffEnd_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CWaitBuffEnd_003Ed__68(int _003C_003E1__state)
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
	private sealed class _003CWaitBuffShown_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CWaitBuffShown_003Ed__67(int _003C_003E1__state)
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
	private sealed class _003CWaitForCombatEnd_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CWaitForCombatEnd_003Ed__79(int _003C_003E1__state)
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
	private sealed class _003CWaitForEndOfWave_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CWaitForEndOfWave_003Ed__62(int _003C_003E1__state)
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
	private sealed class _003CWaitForShowSelectBuffBox_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

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
		public _003CWaitForShowSelectBuffBox_003Ed__69(int _003C_003E1__state)
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
	private sealed class _003CWaitForTapInArea_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

		public Rect screenRect;

		public float timeout;

		private float _003Ctimer_003E5__2;

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
		public _003CWaitForTapInArea_003Ed__105(int _003C_003E1__state)
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
	private sealed class _003CWaitForTapInUIElementNoForce_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

		public RectTransform uiElement;

		public float timeout;

		private float _003Ctimer_003E5__2;

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
		public _003CWaitForTapInUIElementNoForce_003Ed__107(int _003C_003E1__state)
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
	private sealed class _003CWaitForTapOnUIElement_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

		public RectTransform uiElement;

		public Vector2 positionOffset;

		public float timeout;

		private float _003Ctimer_003E5__2;

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
		public _003CWaitForTapOnUIElement_003Ed__106(int _003C_003E1__state)
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
	private sealed class _003CWaitUntil2ItemsMerged_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECanvasManager _003C_003E4__this;

		public GameObject first;

		public GameObject second;

		public Action<bool> onGearDragging;

		private GameObject _003CfirstItem_003E5__2;

		private GameObject _003CsecondItem_003E5__3;

		private bool _003CshouldShowHand_003E5__4;

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
		public _003CWaitUntil2ItemsMerged_003Ed__82(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitWithSkip_003Ed__146 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float minWaitTime;

		public float maxWaitTime;

		private float _003Ctimer_003E5__2;

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
		public _003CWaitWithSkip_003Ed__146(int _003C_003E1__state)
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

	private List<TutorialDialog> _tutorialDialogs;

	[SerializeField]
	private ElementalTutorial _elementalTutorialPrefab;

	[SerializeField]
	private bool _checkGameTutorialOnStart;

	public bool IsTutorial;

	[SerializeField]
	private GameObject oinkRareSwordPrefab;

	[SerializeField]
	private GameObject _cutSceneParent;

	[SerializeField]
	private Image _cutSceneImage;

	[SerializeField]
	private Image _tutorialHand;

	[SerializeField]
	private Image _tutorialPointHand;

	private Camera _currentCamera;

	[SerializeField]
	private GameObject _textBoxTransforms;

	[SerializeField]
	private TextMeshProUGUI _textBoxTxt;

	[SerializeField]
	private RectTransform _indicatorZone;

	[SerializeField]
	private GameObject _indicator;

	[SerializeField]
	private Image _tooltipImg_Background;

	[SerializeField]
	private Image _tooltipImg_Content;

	[SerializeField]
	private Vector2 _tooltipImg_StartScale;

	[SerializeField]
	private float _showTooltipImgDuration;

	[SerializeField]
	private float _hideTooltipImgDuration;

	[SerializeField]
	private GameObject _shield;

	[SerializeField]
	private Image _dialogCharacterImage;

	[SerializeField]
	private Sprite[] _avatarSprites;

	[SerializeField]
	private CanvasGroup _textBoxCanvasGroup;

	[SerializeField]
	private float _textBoxFadeSpeed;

	[SerializeField]
	private float _textBoxFadeTo;

	[Header("Debug")]
	[SerializeField]
	private GameObject _debugGear;

	private float alpha;

	private GameObject _currentItemFTUE;

	private RewardPhaseTraitShop rewardPhaseTraitShop;

	private Sequence tutorialHandSequence;

	private WorldUI worldUI;

	private Coroutine idleHighlightCoroutine;

	[SerializeField]
	private bool _checkHomeTutorialOnStart;

	[SerializeField]
	private Sprite[] _cutSceneSprites;

	[SerializeField]
	private VideoPlayer videoPlayer;

	[SerializeField]
	private GameObject _cameraVideo;

	[SerializeField]
	private float[] _skipableTimes;

	[SerializeField]
	private float _skipMinDistane;

	[SerializeField]
	private float _cooldownBetweenSkip;

	[SerializeField]
	[Tooltip("Delay before showing dungeon tutorial after talent upgrade. Set to negative value to disable navigation.")]
	private float _delayBeforeDungeonTutorialAfterTalent;

	[SerializeField]
	private GameObject _tapToSkipText;

	[SerializeField]
	private MMAdditiveSceneLoadingManagerSettings _toGameplayLoadingSettings;

	[SerializeField]
	private Vector2 _eqmIndicatorOffset;

	[SerializeField]
	private Vector2 _eqmIndicatorSizePadding;

	public static FTUECanvasManager Instance { get; private set; }

	private PlayerInfo playerInfo => null;

	[field: SerializeField]
	public UIObjectHighlighter ObjHighlighter { get; private set; }

	private Bag Bag => null;

	public GameObject CircleIndicator => null;

	public BagContentDropArea BagContentDropArea => null;

	public WorldUI GetWorldUI()
	{
		return null;
	}

	public GameObject GetPigRareSwordPrefab()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void CheckGameTutorialOnStart()
	{
	}

	public void ToggleBackground(BGType bgType)
	{
	}

	public Sequence CreateHandForWorldUi(Transform startTarget, Transform endTarget)
	{
		return null;
	}

	private Sequence CreateHand(Vector3 from, Vector3 to = default(Vector3), bool ignoreTimescale = false)
	{
		return null;
	}

	public void ForcePlayerTap(GameObject target, float indicatorSize = 1f)
	{
	}

	private void ForcePlayerTap(GameObject target, Camera cam, float indicatorSize = 1f)
	{
	}

	public void CreateIndicatorZone(Vector2 position, Vector2 offset, Vector2 deltaSize, bool isAnim = false)
	{
	}

	public void CreateIndicatorZone(Vector2 position, Vector2 deltaSize, bool isAnim = false)
	{
	}

	private void DebugItems()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForEndOfWave_003Ed__62))]
	private IEnumerator WaitForEndOfWave()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadingWhenActionTextBox_003Ed__63))]
	private IEnumerator FadingWhenActionTextBox()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CContinuousAlphaLerp_003Ed__64))]
	private IEnumerator ContinuousAlphaLerp()
	{
		return null;
	}

	private void FTUE_InGame_1()
	{
	}

	[IteratorStateMachine(typeof(_003CFTUE_InGame_1Coroutine_003Ed__66))]
	private IEnumerator FTUE_InGame_1Coroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitBuffShown_003Ed__67))]
	private IEnumerator WaitBuffShown()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitBuffEnd_003Ed__68))]
	private IEnumerator WaitBuffEnd()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitForShowSelectBuffBox_003Ed__69))]
	[Obsolete]
	private IEnumerator WaitForShowSelectBuffBox()
	{
		return null;
	}

	private void FTUE_InGame1_2()
	{
	}

	private void FTUE_GiveRareSword()
	{
	}

	[IteratorStateMachine(typeof(_003CFTUE_InGame_1_2Coroutine_003Ed__72))]
	private IEnumerator FTUE_InGame_1_2Coroutine()
	{
		return null;
	}

	private IGrouping<int, Gear> FindSameIdGears()
	{
		return null;
	}

	public List<Gear> FindAvailableGears(int id)
	{
		return null;
	}

	private void FTUE_InGame1_3()
	{
	}

	[IteratorStateMachine(typeof(_003CFTUE_InGame_1_3Coroutine_003Ed__76))]
	private IEnumerator FTUE_InGame_1_3Coroutine()
	{
		return null;
	}

	private void FTUE_InGame1_4()
	{
	}

	[IteratorStateMachine(typeof(_003CFTUE_InGame_1_4Coroutine_003Ed__78))]
	private IEnumerator FTUE_InGame_1_4Coroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitForCombatEnd_003Ed__79))]
	private IEnumerator WaitForCombatEnd()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CForceMoveGearToBag_003Ed__80))]
	public IEnumerator ForceMoveGearToBag(Gear gear)
	{
		return null;
	}

	private (GameObject, GameObject) SwapIfThereIsInBag(GameObject firstItem, GameObject secondItem)
	{
		return default;
	}

	[IteratorStateMachine(typeof(_003CWaitUntil2ItemsMerged_003Ed__82))]
	public IEnumerator WaitUntil2ItemsMerged(GameObject first, GameObject second, Action<bool> onGearDragging = null)
	{
		return null;
	}

	public void FTUE_IntroduceFunctionSlots()
	{
	}

	public void FTUE_IntroduceFunctionStows()
	{
	}

	public void IntroduceElementalCounter(bool ignoreCompletedFlag = false)
	{
	}

	[IteratorStateMachine(typeof(_003CIntroduceFunctionSlots_003Ed__86))]
	private IEnumerator IntroduceFunctionSlots()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CIntroduceStows_003Ed__87))]
	private IEnumerator IntroduceStows()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHighlightItemWhenIdle_003Ed__89))]
	private IEnumerator HighlightItemWhenIdle()
	{
		return null;
	}

	public void LockSquares()
	{
	}

	public void ShowHandPointHere(Vector2 position, Vector2 offset, bool useTap = false)
	{
	}

	public void ShowHandPointHere(Vector2 position, bool useTap = false)
	{
	}

	public void ShowHandPointHereLeftToRight(Vector2 position, bool useTap = false)
	{
	}

	private void HandleHand(Vector3 position, bool useTap, int fromDirection)
	{
	}

	public Vector2 CameraToScreen(Transform transform)
	{
		return default;
	}

	public void SetTextBox(string txt, Vector2 position, int avatarIndex = -1, bool ignoreTimescale = false)
	{
	}

	public void SetTextBox(TutorialStep step)
	{
	}

	[Obsolete]
	public void SetTextBox(string tutorialKey)
	{
	}

	public bool IsTapInScreenArea(Rect screenRect)
	{
		return false;
	}

	public bool IsTapOnUIElement(RectTransform uiElement)
	{
		return false;
	}

	public bool IsTapOnButton(Button button)
	{
		return false;
	}

	public bool IsTapOnGameObject(GameObject target, Camera camera = null)
	{
		return false;
	}

	public bool IsTapInWorldArea(Vector3 worldCenter, float radius, Camera camera = null)
	{
		return false;
	}

	private Vector2 GetTapPosition()
	{
		return default;
	}

	[IteratorStateMachine(typeof(_003CWaitForTapInArea_003Ed__105))]
	public IEnumerator WaitForTapInArea(Rect screenRect, float timeout = -1f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitForTapOnUIElement_003Ed__106))]
	public IEnumerator WaitForTapOnUIElement(RectTransform uiElement, float timeout = -1f, Vector2 positionOffset = default(Vector2))
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitForTapInUIElementNoForce_003Ed__107))]
	public IEnumerator WaitForTapInUIElementNoForce(RectTransform uiElement, float timeout = -1f)
	{
		return null;
	}

	public void TestTapOnGear(int gearIndex = 1)
	{
	}

	[IteratorStateMachine(typeof(_003CTestTapOnGearCoroutine_003Ed__109))]
	private IEnumerator TestTapOnGearCoroutine(int gearIndex)
	{
		return null;
	}

	public void TestTapInBottomRight()
	{
	}

	[IteratorStateMachine(typeof(_003CTestTapInBottomRightCoroutine_003Ed__111))]
	private IEnumerator TestTapInBottomRightCoroutine()
	{
		return null;
	}

	public void ShowTapHint(Vector3 worldPosition, float duration = 2f)
	{
	}

	[IteratorStateMachine(typeof(_003CHideTapHintAfterDelay_003Ed__113))]
	private IEnumerator HideTapHintAfterDelay(float delay)
	{
		return null;
	}

	[Obsolete("Use Globals.TrackFTUEStep()")]
	private void TrackEvent(string step)
	{
	}

	private void FTUE_IntroduceSkills()
	{
	}

	[IteratorStateMachine(typeof(_003CIntroduceSkills_003Ed__116))]
	private IEnumerator IntroduceSkills()
	{
		return null;
	}

	private void GetDialogContent()
	{
	}

	public void DisableIndicatorZone()
	{
	}

	public void DisableTutorialPointHand(bool killAnimation = true)
	{
	}

	public void DisableTutorialHand(bool killAnimation = true)
	{
	}

	public void ShowToolTipImg(float duration = 0.5f)
	{
	}

	public void HideToolTipImg(float duration = 0.5f)
	{
	}

	private void Update()
	{
	}

	private void RunDungeonTutorial()
	{
	}

	public void Test()
	{
	}

	public void CheckHomeTutorialOnStart()
	{
	}

	public void CheckHomeTutorial(string tutorialKey)
	{
	}

	private void FTUE_First_CutScene()
	{
	}

	private void OnTalentUpgraded(int id)
	{
	}

	[IteratorStateMachine(typeof(_003CShowDungeonTutorialAfterDelay_003Ed__142))]
	private IEnumerator ShowDungeonTutorialAfterDelay(float delay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayVideoCoroutine_003Ed__143))]
	private IEnumerator PlayVideoCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFTUE_First_CutSceneCoroutine_003Ed__144))]
	private IEnumerator FTUE_First_CutSceneCoroutine()
	{
		return null;
	}

	public void SkipTo(float second)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitWithSkip_003Ed__146))]
	private IEnumerator WaitWithSkip(float minWaitTime, float maxWaitTime)
	{
		return null;
	}

	public void ShowHandPointHereOnHome(Vector2 position, bool useTap = false)
	{
	}

	public void ShowHandPointHereOnHome(Vector2 position, Vector2 offset, bool useTap = false)
	{
	}

	private void PerformFinalCutsceneAction(Action onComplete = null)
	{
	}

	public void ShowFeatureTutorial(string featureName)
	{
	}

	[IteratorStateMachine(typeof(_003CShowEquipmentTutorial_003Ed__151))]
	private IEnumerator ShowEquipmentTutorial()
	{
		return null;
	}

	public void ShowEquipmentSubStatIndicator(RectTransform subStat, bool isAnim = true)
	{
	}

	[IteratorStateMachine(typeof(_003CShowTalentTutorial_003Ed__153))]
	private IEnumerator ShowTalentTutorial()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowDungeonTutorial_003Ed__154))]
	private IEnumerator ShowDungeonTutorial()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShow7DayTutorial_003Ed__155))]
	private IEnumerator Show7DayTutorial()
	{
		return null;
	}

	public void ForceTapButton(GameObject buttonGO)
	{
	}

	public void ActiveShield(bool active)
	{
	}
}
