using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Game.CodedAnimation;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class BoomerangStyle : ProjectileBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLaunch_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BoomerangStyle _003C_003E4__this;

			public Vector3 reachPosition;

			public float reachDuration;

			public float stopDuration;

			public Vector3 returnPosition;

			public float returnDuration;

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
			public _003CLaunch_003Ed__6(int _003C_003E1__state)
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
		private EaseOrAnimationCurve _moveEase;

		[SerializeField]
		private EaseOrAnimationCurve _returnEase;

		private Tween _towardTween;

		private Tween _returnTween;

		private void OnDisable()
		{
		}

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		[IteratorStateMachine(typeof(_003CLaunch_003Ed__6))]
		private IEnumerator Launch(Vector3 reachPosition, float reachDuration, float stopDuration, Vector3 returnPosition, float returnDuration)
		{
			return null;
		}

		public void OnHit(GameObject target)
		{
		}

		private void CheckStopOnTarget()
		{
		}
	}
}
