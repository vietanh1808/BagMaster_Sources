using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public abstract class MeleeBehaviour : ProjectileBehaviour
	{
		[SerializeField]
		protected float _reachDistanceOffset;

		[SerializeField]
		private float _minimumReachDistance;

		[SerializeField]
		private Vector2 _aimOffset;

		protected MeleeHitbox _hitbox;

		protected Transform _weapon;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		protected abstract void MeleeAttack(Transform weapon, float distance, Vector3 direction);
	}
}
