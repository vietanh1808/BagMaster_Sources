using System;

namespace Game.Combat
{
	public class BeShieldedComponent : SafeDisposeable, ISkillComponent
	{
		private IDisposable _listener;

		public BeShieldedComponent(SimpleSkill skill)
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
