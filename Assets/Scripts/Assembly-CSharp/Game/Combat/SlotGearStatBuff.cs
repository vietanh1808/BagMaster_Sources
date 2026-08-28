namespace Game.Combat
{
	public class SlotGearStatBuff : ISlotBuff
	{
		private StatName _statName;

		private StatModifier _modifier;

		private SlotBuffCondition _condition;

		public SlotGearStatBuff(StatName gearStat, float value, ModificationType modificationType, SlotBuffCondition condition)
		{
		}

		public bool Apply(Gear gear)
		{
			return false;
		}

		public void Remove(Gear gear)
		{
		}
	}
}
