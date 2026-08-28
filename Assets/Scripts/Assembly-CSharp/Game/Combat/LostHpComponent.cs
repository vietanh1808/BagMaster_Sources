using System;

namespace Game.Combat
{
	public class LostHpComponent : SafeDisposeable, ISkillComponent
	{
		private IDisposable _listener;

		public LostHpComponent(SimpleSkill skill)
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
