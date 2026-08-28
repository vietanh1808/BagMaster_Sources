using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class BagUnityPositionService
	{
		public enum MoveType
		{
			Instant = 0,
			Tween = 1
		}

		private readonly Transform _gearContainer;

		private readonly BagGridMap _gridMap;

		private Dictionary<IBagGridItem, Vector3> _worldPositions;

		public BagUnityPositionService(Transform gearContainer, BagGridMap gridMap)
		{
		}

		public void Copy(BagUnityPositionService other)
		{
		}

		public void SaveItem(IBagGridItem item, Vector2Int[] gridPositions)
		{
		}

		public void RemoveItem(IBagGridItem item)
		{
		}

		public bool TryGetWorldPositionOfItemInBag(IBagGridItem item, out Vector3 position)
		{
			position = default;
			return false;
		}

		public Vector3 GetWorldDropPosition(IBagGridItem item, Vector2Int[] gridPositions)
		{
			return default;
		}

		public Vector3 GetDropLocalPosition(IBagGridItem item, Vector2Int[] gridPositions)
		{
			return default;
		}

		public Vector3 GetWorldPosition(Vector2Int gridPosition)
		{
			return default;
		}

		public void MoveItemBy(IBagGridItem item, Vector2Int motion, MoveType moveType)
		{
		}

		public void MoveItemTo(IBagGridItem item, Vector2Int[] newPositions, MoveType moveType)
		{
		}

		public void PreviewItemBy(IBagGridItem item, Vector2Int motion)
		{
		}

		public void PreviewItemAt(IBagGridItem item, Vector2Int[] previewPositions)
		{
		}

		private Vector2Int[] MovePositionsBy(Vector2Int[] positions, Vector2Int motion)
		{
			return null;
		}
	}
}
