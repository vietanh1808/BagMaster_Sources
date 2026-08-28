namespace Game.Combat
{
	public class EmptyCondition : MonsterBehaviourCondition
	{
		public override bool IsConditionOk()
		{
			return false;
		}
	}
}
