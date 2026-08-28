using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class GameplayBagSaveInitializer : MonoBehaviour
	{
		[SerializeField]
		private BagLayoutManager _layoutManager;

		[Header("Events")]
		public UnityEvent<Vector2Int> OnCreateSquareEvent;

		public UnityEvent<NewSlot> OnCreateNewSlotEvent;

		public UnityEvent OnCompleted;

		public UnityEvent OnFailed;

		protected virtual void Start()
		{
		}

		private void RemoveAllSquaresInLayout(GameObject layout)
		{
		}

		private void InitializedSaveSquares(IntArray[] positions)
		{
		}

		private void InitializeNewSlots(GameObject layout, IntArray[] unlockedPositions)
		{
		}

		private bool AlreadyUnlocked(NewSlot newSlot, IntArray[] unlockedPositions)
		{
			return false;
		}
	}
}
