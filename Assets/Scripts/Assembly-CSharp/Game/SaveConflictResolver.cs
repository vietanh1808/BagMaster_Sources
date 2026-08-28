namespace Game
{
	public static class SaveConflictResolver
	{
		public static bool ShouldPreferCloud(PlayerInfo local, PlayerInfo cloud)
		{
			return false;
		}

		private static int GetChapter(PlayerInfo info)
		{
			return 0;
		}

		private static long GetPlayTime(PlayerInfo info)
		{
			return 0L;
		}
	}
}
