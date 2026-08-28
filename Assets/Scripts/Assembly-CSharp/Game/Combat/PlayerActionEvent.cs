using R3;

namespace Game.Combat
{
	public static class PlayerActionEvent
	{
		private static Subject<PlayerActionEventData> _playerActionSubject;

		public static Observable<PlayerActionEventData> PlayerActionObserver => null;

		public static void Trigger(PlayerActionEventType eventType)
		{
		}

		public static void Trigger(PlayerActionEventData eventData)
		{
		}
	}
}
