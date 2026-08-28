namespace Game
{
	public struct GamePhaseEvent
	{
		private static GamePhaseEvent e;

		public GamePhase Phase;

		public static void Trigger(GamePhase phase)
		{
		}
	}
}
