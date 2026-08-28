using System;

namespace Game
{
	[Serializable]
	public class PlayerDataMeta
	{
		public string Version;

		public long TotalPlayTimeSeconds;

		public int ChapterProgress;

		public int Gem;

		public int Gold;

		public long DateTime;
	}
}
