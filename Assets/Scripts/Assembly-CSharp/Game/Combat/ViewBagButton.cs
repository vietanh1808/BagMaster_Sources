using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Combat
{
	public class ViewBagButton : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitToUnpeekBag_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ViewBagButton _003C_003E4__this;

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
			public _003CWaitToUnpeekBag_003Ed__8(int _003C_003E1__state)
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
		private Image _peekBagButton;

		[SerializeField]
		private float _minimumPeekDuration;

		[Header("Events")]
		public UnityEvent OnPeekedEvent;

		public UnityEvent OnUnpeekedEvent;

		private Sequence _peekSequence;

		private float _peekTime;

		public void OpenBag()
		{
		}

		public void CloseBag()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitToUnpeekBag_003Ed__8))]
		private IEnumerator WaitToUnpeekBag()
		{
			return null;
		}
	}
}
