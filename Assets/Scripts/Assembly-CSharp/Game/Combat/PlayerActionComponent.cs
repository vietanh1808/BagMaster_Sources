using System;

namespace Game.Combat
{
	public class PlayerActionComponent : SafeDisposeable, ISkillComponent
	{
		private IDisposable _listener;

		public SimpleSkill Skill { get; private set; }

		public PlayerActionComponent(SimpleSkill skill, PlayerActionEventType eventType)
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
