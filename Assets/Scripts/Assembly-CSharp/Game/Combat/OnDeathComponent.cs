using System;

namespace Game.Combat
{
	public class OnDeathComponent : SafeDisposeable, ISkillComponent
	{
		private IDisposable _subscription;

		public SimpleSkill Skill { get; private set; }

		public OnDeathComponent(SimpleSkill skill)
		{
		}

		private void OnDeath()
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
