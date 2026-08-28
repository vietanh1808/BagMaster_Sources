namespace Game.Combat
{
	public static class ValidationUtility
	{
		public static bool HasTag(IHasTags hasTag, string[] validTags)
		{
			return false;
		}

		public static bool IsTargetId(IHasTags hasTag, int validId)
		{
			return false;
		}

		public static bool IsMergeLevelValid(Gear gear, int compareValue, CompareType compareType)
		{
			return false;
		}
	}
}
