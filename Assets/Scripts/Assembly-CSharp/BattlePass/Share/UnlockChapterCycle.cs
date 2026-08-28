using System;
using _Game.Events.Imp;
using _Game.Events.Model;

namespace BattlePass.Share
{
	[Serializable]
	public class UnlockChapterCycle : ICycleDefinition
	{
		public bool TryGetCycle(string eventId, ICycleParseTime parseTime, long nowUtc, out int seasonId, out long cycleStartUtc, out long cycleEndUtc)
		{
			seasonId = default;
			cycleStartUtc = default;
			cycleEndUtc = default;
			return false;
		}
	}
}
