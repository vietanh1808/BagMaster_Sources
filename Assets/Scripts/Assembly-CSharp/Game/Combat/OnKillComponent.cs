namespace Game.Combat
{
	public class OnKillComponent : ISkillComponent, IOnKillListener
	{
		public SimpleSkill Skill { get; private set; }

		public OnKillComponent(SimpleSkill skill)
		{
		}

		public void OnKill(Health target)
		{
		}
	}
}
