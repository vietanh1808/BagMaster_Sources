using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class EmptyStyle : ProjectileBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayHit_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public EmptyStyle _003C_003E4__this;

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
			public _003CDelayHit_003Ed__3(int _003C_003E1__state)
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
		private float _delay;

		private Coroutine _coroutine;

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayHit_003Ed__3))]
		private IEnumerator DelayHit(float delay)
		{
			return null;
		}

		private void Hit()
		{
		}
	}
}
