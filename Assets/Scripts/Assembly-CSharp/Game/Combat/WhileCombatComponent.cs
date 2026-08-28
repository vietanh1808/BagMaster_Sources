using R3;

namespace Game.Combat
{
	public class WhileCombatComponent : SafeDisposeable, ISkillComponent
	{
		private DisposableBag _listeners;

		public SimpleSkill Skill { get; private set; }

		public WhileCombatComponent(SimpleSkill skill)
		{
		}

		private void Do()
		{
		}

		private void Undo()
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
