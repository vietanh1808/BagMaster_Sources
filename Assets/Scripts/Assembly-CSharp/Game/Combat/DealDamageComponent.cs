using System;

namespace Game.Combat
{
	public class DealDamageComponent : SafeDisposeable, ISkillComponent
	{
		private IDisposable _listener;

		public DealDamageComponent(SimpleSkill skill)
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
