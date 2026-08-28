using System;
using Newtonsoft.Json;

namespace Game.EventDungeon
{
	[Serializable]
	public class EventDungeonProgressData
	{
		public int eventDungeonID;

		public int unlockedLevel;

		public int nextLevel;

		public int maxLevel;

		public bool isCompleted;

		public int adsBuyTicketTimes;

		public int buyTicketTimes;

		[JsonIgnore]
		public bool IsMaxLevel => false;
	}
}
