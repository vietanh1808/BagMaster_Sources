namespace Game.Combat
{
	public struct FloatGearVisibleEvent
	{
		public int PlayerId;

		public bool UseFade;

		public static void Trigger(int playerId, bool useFade)
		{
		}
	}
}
