namespace Game.Arena
{
	public static class RankMethod
	{
		public static string GetName(this RankType type)
		{
			return null;
		}

		public static string GetTranslationName(this RankType type)
		{
			return null;
		}

		public static RankType ConvertToRankType(this int rankID)
		{
			return RankType.None;
		}

		public static RankType IncreaseRankType(this RankType rank)
		{
			return RankType.None;
		}

		public static RankType DecreaseRankType(this RankType rank)
		{
			return RankType.None;
		}
	}
}
