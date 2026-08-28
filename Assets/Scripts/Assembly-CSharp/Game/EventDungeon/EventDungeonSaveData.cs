using System;
using System.Collections.Generic;
using Game.Shop;

namespace Game.EventDungeon
{
	[Serializable]
	public class EventDungeonSaveData
	{
		public DateTime? lastEventDungeonCheckingDate;

		public ShopRefreshTime ED_RefreshTime { get; private set; }

		public List<EventDungeonProgressData> EventDungeonProgress { get; private set; }

		public EventDungeonProgressData GetEventDungeonProgress(int dungeonEventID)
		{
			return null;
		}

		public void ClearAllProgress()
		{
		}

		public bool AnyEventDungeonProgressData()
		{
			return false;
		}

		public void EventDungeonCheckIn(out bool isNewDay)
		{
			isNewDay = default;
		}
	}
}
