using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Game.Combat
{
	public class GearVFXStartEffect : MonoBehaviour, IHasStartCombatEffect
	{
		[CompilerGenerated]
		private sealed class _003CRunEffect_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearVFXStartEffect _003C_003E4__this;

			private IEnumerator<Gear> _003C_003E7__wrap1;

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
			public _003CRunEffect_003Ed__9(int _003C_003E1__state)
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

		[SerializeField]
		private GameObject _vfxPrefab;

		[SerializeField]
		private float _delayBetween;

		[SerializeField]
		private float _totalDelay;

		[SerializeField]
		private Camera _uiCamera;

		public int Order => 0;

		public float EffectDuration => 0f;

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CRunEffect_003Ed__9))]
		public IEnumerator RunEffect()
		{
			return null;
		}
	}
}
