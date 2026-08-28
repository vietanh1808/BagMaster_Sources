using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class LaserStyle : BeamStyle
	{
		private Transform _endPoint;

		private void LateUpdate()
		{
		}

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		protected override bool DoBeam()
		{
			return false;
		}

		public virtual void OnHit(GameObject target)
		{
		}
	}
}
