using Game.Combat;
using UnityEngine;
using UnityEngine.Events;

namespace Game
{
	public class KingdomBagSaveInitializer : MonoBehaviour
	{
		[Header("Events")]
		public UnityEvent<Vector2Int> OnCreateSquareEvent;

		public UnityEvent<NewSlot> OnCreateNewSlotEvent;

		public UnityEvent OnCompleted;

		public UnityEvent OnFailed;

		private void Start()
		{
		}
	}
}
