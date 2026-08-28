using Game.Combat.SkillSystem;

namespace Game.Combat
{
	public class MoveToEnemyAction : MoveToAction
	{
		private IFilter _targetFilter;

		public MoveToEnemyAction(Unit owner)
			: base(null, default)
		{
		}

		public override void Execute()
		{
		}
	}
}
