using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.Tools;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class FlamethrowerStyle : ProjectileBehaviour, IUpdater
	{
		[CompilerGenerated]
		private sealed class _003CFlyToFirePoint_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FlamethrowerStyle _003C_003E4__this;

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
			public _003CFlyToFirePoint_003Ed__17(int _003C_003E1__state)
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
		private GameObject _streamVfx;

		[SerializeField]
		private ProjectileHitBox _hitBox;

		[SerializeField]
		private ProjectileController _projectileController;

		[SerializeField]
		private float _moveToFirePointDuration;

		[SerializeField]
		private bool _moveToBetterPosition;

		private Transform _positionAnchor;

		private Vector3 _positionOffset;

		private Transform _rotationAnchor;

		private float _rotationOffset;

		private bool _towaradAnchor;

		private Vector3 _muzzleInitialPosition;

		private Transform _backMuzzle;

		private FloatGearAnimator _cachedAnimator;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		void IUpdater.CustomUpdate(float dt)
		{
		}

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		[IteratorStateMachine(typeof(_003CFlyToFirePoint_003Ed__17))]
		private IEnumerator FlyToFirePoint()
		{
			return null;
		}

		private void SetupPositionNRotation()
		{
		}

		private Transform GetPositionAnchor()
		{
			return null;
		}

		public Transform GetRotationAnchor()
		{
			return null;
		}

		public void Hit(GameObject target)
		{
		}
	}
}
