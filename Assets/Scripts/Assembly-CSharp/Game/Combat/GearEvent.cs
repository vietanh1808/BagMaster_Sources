namespace Game.Combat
{
	public struct GearEvent
	{
		public enum Type
		{
			PlacedIntoBag = 0,
			PlacedIntoCounter = 1
		}

		private static GearEvent e;

		public Gear Gear;

		public Type Interaction;

		public static void Trigger(Gear item, Type interaction)
		{
		}
	}
}
