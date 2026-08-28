using Game.Tools;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class OrbitStyle : ProjectileBehaviour, IUpdater
	{
		public float MoveToRadiusSpeed;

		[Tooltip("Degrees per second the bullet travels around the caster. Positive = counter-clockwise.")]
		public float AngularSpeed;

		[Header("Hit Settings")]
		public ProjectileHitBox HitBox;

		[Header("Runtime")]
		[Tooltip("Radius of the orbit around the caster.")]
		public float OrbitRadius;

		public float SpeedScale;

		public int Pierce;

		private Transform _pivotTransform;

		private float _currentAngle;

		private float _currentAngularSpeed;

		private float _currentRadiusSpeed;

		private float _currentRadius;

		private bool _isEnded;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		void IUpdater.CustomUpdate(float dt)
		{
		}

		public void OnHit(GameObject target)
		{
		}

		private void ApplyOrbitPosition()
		{
		}
	}
}
