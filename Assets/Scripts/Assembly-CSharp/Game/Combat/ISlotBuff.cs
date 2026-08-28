namespace Game.Combat
{
	public interface ISlotBuff
	{
		bool Apply(Gear gear);

		void Remove(Gear gear);
	}
}
