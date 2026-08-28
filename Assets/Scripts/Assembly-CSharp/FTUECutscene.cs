using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class FTUECutscene : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFade_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECutscene _003C_003E4__this;

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
		public _003CFade_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CWaitToPlay_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECutscene _003C_003E4__this;

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
		public _003CWaitToPlay_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CWaitVideoCompleted_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FTUECutscene _003C_003E4__this;

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
		public _003CWaitVideoCompleted_003Ed__21(int _003C_003E1__state)
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

	[SerializeField]
	private VideoPlayer _videoPlayer;

	[SerializeField]
	private GameObject _tapToSkipText;

	[SerializeField]
	private GameObject[] _inPlayings;

	[SerializeField]
	private float[] _skipableTimes;

	[SerializeField]
	private float _skipMinDistane;

	[SerializeField]
	private float _cooldownBetweenSkip;

	[SerializeField]
	private Image _white;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private float _fadeInTime;

	[SerializeField]
	private float _fadeOutTime;

	private bool _seekCompleted;

	public static bool IsCompleted { get; private set; }

	private void Start()
	{
	}

	private void Update()
	{
	}

	public bool ShouldPlay()
	{
		return false;
	}

	public void PreparePlay()
	{
	}

	public void PlayFTUECutscene()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitToPlay_003Ed__20))]
	private IEnumerator WaitToPlay()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitVideoCompleted_003Ed__21))]
	private IEnumerator WaitVideoCompleted()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFade_003Ed__22))]
	public IEnumerator Fade()
	{
		return null;
	}

	[Obsolete("Use Globals.TrackFTUEStep()")]
	private void TrackEvent(string step)
	{
	}
}
