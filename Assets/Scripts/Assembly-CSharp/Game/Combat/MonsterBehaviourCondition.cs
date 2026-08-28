namespace Game.Combat
{
	public abstract class MonsterBehaviourCondition
	{
		public bool IsNegative;

		public abstract bool IsConditionOk();
	}
}
