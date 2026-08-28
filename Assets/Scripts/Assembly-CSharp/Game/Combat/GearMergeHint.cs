using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class GearMergeHint : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitToHint_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Gear waitGear;

			public GearMergeHint _003C_003E4__this;

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
			public _003CWaitToHint_003Ed__13(int _003C_003E1__state)
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
		private LineRenderer _mergeConnectionLinePrefab;

		[SerializeField]
		private float _hintZ;

		[SerializeField]
		private MMF_Player _hintFeedback;

		[SerializeField]
		private float _delayIfHasSynercy;

		private Func<Gear, bool> _mergeableFunc;

		private LineRenderer _mergeConnectionLine;

		private Gear _mergeableGear;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SetMergeableFunc(Func<Gear, bool> func)
		{
		}

		private void OnDraggingGearChanged(Gear gear)
		{
		}

		private bool CanMerged(Gear checkGear)
		{
			return false;
		}

		public void Hint(Gear waitGear)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitToHint_003Ed__13))]
		private IEnumerator WaitToHint(Gear waitGear)
		{
			return null;
		}

		public void TriggerFeedback()
		{
		}
	}
}
