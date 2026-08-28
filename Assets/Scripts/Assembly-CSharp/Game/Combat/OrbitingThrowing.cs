using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Game.Combat
{
	public class OrbitingThrowing : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public SimpleSkill simpleSkill;

			internal bool _003CWaitToShowOfThrowType_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitToShowOfThrowType_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SimpleSkill simpleSkill;

			public OrbitingThrowing _003C_003E4__this;

			private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

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
			public _003CWaitToShowOfThrowType_003Ed__6(int _003C_003E1__state)
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
		private GameObject _renderer;

		private Vector3 _rendererInitialScale;

		private IDisposable _throwingDispose;

		private void OnDestroy()
		{
		}

		public void SetThrowing(Gear gear)
		{
		}

		private void DoThrow(SkillExecuteData data)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitToShowOfThrowType_003Ed__6))]
		private IEnumerator WaitToShowOfThrowType(SimpleSkill simpleSkill)
		{
			return null;
		}

		public void Reset()
		{
		}
	}
}
