namespace Game.Combat
{
	public class LessHpCondition : MonsterBehaviourCondition
	{
		protected Health _health;

		protected float _threshold;

		public LessHpCondition(Health health, float threshold)
		{
		}

		public override bool IsConditionOk()
		{
			return false;
		}
	}
}
