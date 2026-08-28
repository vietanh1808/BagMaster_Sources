namespace Game.Combat
{
	public class GreaterHpCondition : LessHpCondition
	{
		public GreaterHpCondition(Health health, float threshold)
			: base(null, 0f)
		{
		}

		public override bool IsConditionOk()
		{
			return false;
		}
	}
}
