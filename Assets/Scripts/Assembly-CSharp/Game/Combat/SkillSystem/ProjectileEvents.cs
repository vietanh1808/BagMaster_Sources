using System;

namespace Game.Combat.SkillSystem
{
	public class ProjectileEvents
	{
		public Action<IEffectTarget> OnHitEvent;

		public Action OnEndEvent;
	}
}
