using DG.Tweening;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class ThrowStyle : ProjectileBehaviour
	{
		public float SpeedInSecond;

		public float YForceMin;

		public float YForceMax;

		public ProjectileHitBox HitBox;

		public Ease Ease;

		public bool EndOnHit;

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		private void DoThrow(Vector3 start, Vector3 end)
		{
		}

		private void Hit()
		{
		}

		public virtual void OnHit(GameObject target)
		{
		}
	}
}
