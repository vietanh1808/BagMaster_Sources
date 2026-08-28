using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class Loop : BaseEffectImp
	{
		[CompilerGenerated]
		private sealed class _003CRunLoop_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Loop _003C_003E4__this;

			public GameObject target;

			private float _003CendTime_003E5__2;

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
			public _003CRunLoop_003Ed__5(int _003C_003E1__state)
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

		[Header("Loop")]
		public float Interval;

		public float Duration;

		private Dictionary<GameObject, Coroutine> _loops;

		public override void Initialize(EffectParams effectParams)
		{
		}

		public override void Execute(GameObject target)
		{
		}

		[IteratorStateMachine(typeof(_003CRunLoop_003Ed__5))]
		private IEnumerator RunLoop(GameObject target)
		{
			return null;
		}
	}
}
