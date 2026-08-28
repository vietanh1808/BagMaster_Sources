using System;

namespace Game.Combat
{
	public class BeHealedComponent : SafeDisposeable, ISkillComponent
	{
		private IDisposable _listener;

		public BeHealedComponent(SimpleSkill skill)
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
