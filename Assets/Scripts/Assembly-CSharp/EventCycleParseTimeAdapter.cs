using System;
using _Game.Events.Imp;

[Serializable]
public class EventCycleParseTimeAdapter : ICycleParseTime
{
	public bool TryParse(string eventId, long nowUtc, out int seasonId, out long cycleStartUtc, out long cycleEndUtc)
	{
		seasonId = default;
		cycleStartUtc = default;
		cycleEndUtc = default;
		return false;
	}
}
