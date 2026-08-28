using System.Collections.Generic;

namespace Game.DailyEvent
{
	public class EventTicketData
	{
		public int EventId;

		public int TicketId;

		public int RebuyLimit;

		public List<ResourceRequireData> RebuyCosts;

		private EventUnlockData _eventData;

		private CurrencyData _ticketData;

		private OwnedResourceEntity _ownedTicketResource;

		public EventUnlockData EventData => null;

		public CurrencyData TicketData => null;

		public OwnedResourceEntity OwnedTicketResource => null;

		public void Cost()
		{
		}

		public bool Has()
		{
			return false;
		}
	}
}
