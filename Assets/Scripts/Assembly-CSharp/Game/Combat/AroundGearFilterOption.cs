using System;

namespace Game.Combat
{
	[Serializable]
	public struct AroundGearFilterOption
	{
		public bool IncludeDiagonal;

		public bool IncludeUp;

		public bool IncludeDown;

		public bool IncludeLeft;

		public bool IncludeRight;

		public static AroundGearFilterOption Default;

		public static AroundGearFilterOption FromStr(string strData)
		{
			return default;
		}
	}
}
