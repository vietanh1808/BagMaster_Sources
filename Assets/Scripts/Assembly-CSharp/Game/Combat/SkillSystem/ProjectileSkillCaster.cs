using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class ProjectileSkillCaster : ProjectileBehaviour
	{
		[SerializeField]
		private bool _useTargetOfParent;

		private List<ECastSkill> _castSkillEffects;

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		private void OnEnd()
		{
		}
	}
}
