using DG.Tweening;
using Game.Tools;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class FollowProjectileStyle : ProjectileBehaviour, IUpdater
	{
		private enum State
		{
			NoTarget = 0,
			JustFoundTarget = 1,
			FollowTarget = 2,
			HitTarget = 3
		}

		public float Speed;

		public Vector2 RotateToNewTargetDuration;

		public AnimationCurve RotateDurationCurve;

		public float Acceleration;

		public float Deceleration;

		public float OwnerReturnOffset;

		public ProjectileHitBox HitBox;

		public int Pierce;

		private ProjectileController _projectileController;

		private Unit _currentTarget;

		private Vector3 _moveDirection;

		private float _moveMultiplier;

		private float _rotationLerpToTarget;

		private Sequence _newTargetSeq;

		private float _interalSpeedScale;

		private StatModifier _extendRange;

		private Stat _rangeExtended;

		private Team _targetTeam;

		private float SpeedScale => 0f;

		private void Start()
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

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		private bool NoTarget()
		{
			return false;
		}

		private void FindNewTarget()
		{
		}

		private Unit FindTarget()
		{
			return null;
		}

		private void Accelerate()
		{
		}

		private void Decelerate()
		{
		}

		private void DetectNewTarget()
		{
		}

		private void DoRotateToTarget()
		{
		}

		private void RotateToTarget()
		{
		}

		private void RotateToOwner(float dt)
		{
		}

		public void OnHit(GameObject target)
		{
		}

		private void UpdatePierce(GameObject target)
		{
		}

		private bool CheckHitWall(GameObject target)
		{
			return false;
		}

		public override void End()
		{
		}

		private void RemoveModifiers()
		{
		}
	}
}
