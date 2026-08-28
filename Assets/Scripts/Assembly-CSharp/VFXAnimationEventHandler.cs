using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class VFXAnimationEventHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDeactivateAfterDelay_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public VFXAnimationEventHandler _003C_003E4__this;

		public int index;

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
		public _003CDeactivateAfterDelay_003Ed__3(int _003C_003E1__state)
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
	private GameObject[] vfxObjects;

	[SerializeField]
	private float vfxLifetime;

	public void PlayVFX(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CDeactivateAfterDelay_003Ed__3))]
	private IEnumerator DeactivateAfterDelay(int index, float delay)
	{
		return null;
	}

	public void PlayVFXAtPosition(int index)
	{
	}

	public void ActivateVFX(int index)
	{
	}

	public void DeactivateVFX(int index)
	{
	}
}
