using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class GameplayBagInitializer : MonoBehaviour
	{
		[SerializeField]
		protected BagLayoutManager _layoutManager;

		[Header("Events")]
		public UnityEvent<Vector2Int> OnCreateSquareEvent;

		public UnityEvent<NewSlot> OnCreateNewSlotEvent;

		public UnityEvent OnCompleted;

		protected virtual void Start()
		{
		}

		protected virtual void InitializeInitialSquares(GameObject layout, out Vector2Int[] unlockedPositions)
		{
			unlockedPositions = null;
		}

		protected virtual void InitializeNewSlots(GameObject layout, Vector2Int[] unlockedPositions)
		{
		}
	}
}
