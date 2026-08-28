using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	public class GearStatusVFX : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLatePlaySynergyVFX_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearStatusVFX _003C_003E4__this;

			public bool value;

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
			public _003CLatePlaySynergyVFX_003Ed__8(int _003C_003E1__state)
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

		private StatusManager _statusManager;

		[SerializeField]
		private List<GameObject> _synergyParticleSystem;

		[SerializeField]
		private int _startLevel;

		public int currentStatusCount;

		public int VFXLevel;

		private Gear gear;

		private Tween _scaleTween;

		[SerializeField]
		private float _scaleDuration;

		[SerializeField]
		private float _scalePercent;

		[SerializeField]
		private AnimationCurve _scaleEase;

		private void Start()
		{
		}

		public void FetchVFXbaseOnStatus()
		{
		}

		[IteratorStateMachine(typeof(_003CLatePlaySynergyVFX_003Ed__8))]
		private IEnumerator LatePlaySynergyVFX(bool value)
		{
			return null;
		}

		public void PlaySynergyEffect(bool value)
		{
		}

		public void ScaleUp(int scaleTime)
		{
		}

		public void ResetScale()
		{
		}
	}
}
