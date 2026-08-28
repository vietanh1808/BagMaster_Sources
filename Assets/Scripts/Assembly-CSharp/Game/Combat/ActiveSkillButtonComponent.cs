using System;

namespace Game.Combat
{
	public class ActiveSkillButtonComponent : SafeDisposeable, ISkillComponent, IEffectCooldownInBag
	{
		private SimpleSkill _skill;

		private IDisposable _listener;

		public ActiveSkillButtonComponent(SimpleSkill skill)
		{
		}

		private void UpdateIntensity()
		{
		}

		private Stat GetStat()
		{
			return null;
		}

		protected override void DoDispose()
		{
		}
	}
}
