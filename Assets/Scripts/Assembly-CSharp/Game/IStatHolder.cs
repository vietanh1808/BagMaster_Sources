namespace Game
{
	public interface IStatHolder
	{
		Stat Get(StatName statName);

		void Set(StatName statName, Stat stat);
	}
}
