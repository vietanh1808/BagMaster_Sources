using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Game.Combat
{
	public class GearLuckyEffectSpawner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public Gear gear;

			public float counterY;

			public GearLuckyEffectSpawner _003C_003E4__this;

			internal bool _003CDelayShowLuckEffect_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDelayShowLuckEffect_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Gear gear;

			public GearLuckyEffectSpawner _003C_003E4__this;

			private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

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
			public _003CDelayShowLuckEffect_003Ed__5(int _003C_003E1__state)
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
		private GameObject _luckEffectPrefab;

		[SerializeField]
		private float _delay;

		[SerializeField]
		private Transform _counterContent;

		[SerializeField]
		private float _distanceThresold;

		public void ShowLuckEffect(Gear gear)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayShowLuckEffect_003Ed__5))]
		private IEnumerator DelayShowLuckEffect(Gear gear)
		{
			return null;
		}
	}
}
