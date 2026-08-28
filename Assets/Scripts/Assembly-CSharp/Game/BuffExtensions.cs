using Game.Combat;

namespace Game
{
	public static class BuffExtensions
	{
		public static bool IsRecommendedBuffForCurrentLevel(this BuffData buffData)
		{
			return false;
		}

		public static bool IsRecommendedBuff(this BuffData buffData, LevelData levelData)
		{
			return false;
		}
	}
}
