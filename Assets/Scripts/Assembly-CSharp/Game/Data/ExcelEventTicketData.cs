using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelEventTicketData
	{
		public int Event_ID;

		public int Ticket_ID;

		public int Rebuy_Limit;

		public string Rebuy_Cost;
	}
}
