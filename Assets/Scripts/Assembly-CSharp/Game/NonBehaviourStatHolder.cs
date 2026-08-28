using System.Collections.Generic;

namespace Game
{
	public class NonBehaviourStatHolder : IStatHolder
	{
		private Dictionary<StatName, Stat> _stats;

		public Stat Get(StatName statName)
		{
			return null;
		}

		public void Set(StatName statName, Stat stat)
		{
		}
	}
}
