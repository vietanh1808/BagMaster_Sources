using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class CameraAnchor : MonoBehaviour
{
	public enum AnchorType
	{
		BottomLeft = 0,
		BottomCenter = 1,
		BottomRight = 2,
		MiddleLeft = 3,
		MiddleCenter = 4,
		MiddleRight = 5,
		TopLeft = 6,
		TopCenter = 7,
		TopRight = 8
	}

	[CompilerGenerated]
	private sealed class _003CUpdateAnchorAsync_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CameraAnchor _003C_003E4__this;

		private uint _003CcameraWaitCycles_003E5__2;

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
		public _003CUpdateAnchorAsync_003Ed__6(int _003C_003E1__state)
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

	public AnchorType anchorType;

	public Vector3 anchorOffset;

	public Vector3 position;

	private IEnumerator updateAnchorRoutine;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateAnchorAsync_003Ed__6))]
	private IEnumerator UpdateAnchorAsync()
	{
		return null;
	}

	private void UpdateAnchor()
	{
	}

	private void SetAnchor(Vector3 anchor)
	{
	}
}
