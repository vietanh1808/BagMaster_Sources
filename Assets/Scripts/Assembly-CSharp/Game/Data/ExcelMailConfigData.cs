using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelMailConfigData
	{
		public int ID;

		public string TitleKey;

		public string ContentKey;

		public string Rewards;

		public bool FromStart;

		public long StartDay;

		public long EndDay;
	}
}
