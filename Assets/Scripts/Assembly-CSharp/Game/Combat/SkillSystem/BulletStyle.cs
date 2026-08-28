using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Game.Tools;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class BulletStyle : ProjectileBehaviour, IUpdater, IFixedUpdater
	{
		public enum HitTarget
		{
			Creature = 0,
			Wall = 1
		}

		[CompilerGenerated]
		private sealed class _003CDoBounce_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameObject target;

			public BulletStyle _003C_003E4__this;

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
			public _003CDoBounce_003Ed__45(int _003C_003E1__state)
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

		public float MaxSpeed;

		public float StartSpeed;

		public float TimeToReachMaxSpeed;

		public Ease SpeedTweenEase;

		public AnimationCurve AngularSpeedCurve;

		public float DelayAngular;

		public int Pierce;

		public int Bounce;

		public int Follow;

		public Rigidbody2D Rigidbody;

		public ProjectileHitBox HitBox;

		public ProjectileController Controller;

		[Header("Bounce Settings")]
		public float BounceWallRandomAngle;

		[Header("Runtime")]
		[SerializeField]
		protected bool _inBouncing;

		[SerializeField]
		protected bool _inPiercing;

		[SerializeField]
		protected bool _ignoreHitWall;

		[SerializeField]
		protected bool _bounceCreature;

		[SerializeField]
		protected bool _bounceWall;

		[SerializeField]
		protected HitTarget _hitTargetType;

		private static readonly WaitForSeconds _bounceWait;

		protected float _startTime;

		protected float _currentSpeed;

		protected bool _isEnded;

		protected Unit _currentTarget;

		protected Transform _currentTargetTransformPoint;

		protected Team _targetTeam;

		protected Coroutine _doBounce;

		protected Vector2 _lastTargetDiretion;

		private bool _defaultUseOnStay;

		private float _defaultInvincibleDuration;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		void IUpdater.CustomUpdate(float dt)
		{
		}

		void IFixedUpdater.CustomFixedUpdate(float dt)
		{
		}

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		public void TweenVelocity()
		{
		}

		private void UpdateVelocity()
		{
		}

		public virtual void OnHit(GameObject target)
		{
		}

		public override void End()
		{
		}

		private void UpdateFollow()
		{
		}

		private void UpdatePierce()
		{
		}

		private bool CheckHitWall()
		{
			return false;
		}

		private void UpdateBounce(GameObject target)
		{
		}

		[IteratorStateMachine(typeof(_003CDoBounce_003Ed__45))]
		private IEnumerator DoBounce(GameObject target)
		{
			return null;
		}

		private Unit FindTarget(GameObject exclude)
		{
			return null;
		}

		private void BounceDirection(GameObject bounceFromTarget)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
