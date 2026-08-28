using UnityEngine;

namespace Game
{
	public class KingdomPlayerStatHolder : MonoBehaviour, IStatHolder
	{
		private PlayerInfo PInfo => null;

		public Stat Get(StatName statName)
		{
			return null;
		}

		public void Set(StatName statName, Stat stat)
		{
		}
	}
}
