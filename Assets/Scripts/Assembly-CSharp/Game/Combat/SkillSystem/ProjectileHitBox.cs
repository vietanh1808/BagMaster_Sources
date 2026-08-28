using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat.SkillSystem
{
	public class ProjectileHitBox : ProjectileBehaviour
	{
		public LayerMask TargetLayerMask;

		public float InvincibleDuration;

		public bool IsActive;

		public bool UseOnStay;

		public bool IgnoreConfigHitbox;

		public bool AutoEnableCollider;

		public UnityEvent<GameObject> OnHitEvent;

		private InvincibleManager _invincibleManager;

		private List<Collider2D> _colliders;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void OnTriggerStay2D(Collider2D other)
		{
		}

		protected void DoHit(Collider2D other)
		{
		}

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		private void CreateCollider()
		{
		}

		private T GetCollider<T>() where T : Collider2D
		{
			return null;
		}

		public bool IsTarget(GameObject obj)
		{
			return false;
		}

		public bool IsInvincible(GameObject obj)
		{
			return false;
		}

		public virtual void Hit(GameObject target)
		{
		}

		public void EnableCollider(bool enable)
		{
		}
	}
}
