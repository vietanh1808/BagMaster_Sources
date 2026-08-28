namespace Game.Combat
{
	public static class IMergeServiceExtensions
	{
		public static bool CanMerge(this IMergeService mergeService, IBagGridItem item1, IBagGridItem item2)
		{
			return false;
		}

		public static bool TryMerging(this IMergeService mergeService, IBagGridItem item1, IBagGridItem item2)
		{
			return false;
		}
	}
}
