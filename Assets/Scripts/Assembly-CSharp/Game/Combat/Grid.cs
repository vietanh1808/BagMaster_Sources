using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(fileName = "Grid", menuName = "Game/Grid")]
	public class Grid : ScriptableObject
	{
		public Square ValidSquarePrefab;

		public Vector3 Offset;

		public Transform Container;

		public HashSet<Vector2Int> Valids;

		private HashSet<Vector2Int> _useds;

		public void HoverIngoreValid(Transform item, Vector2Int[] placementPoints, Vector3 itemOffset, List<Vector2Int> resultPositions)
		{
		}

		public bool Hover(Transform item, Vector2Int[] placementPoints, Vector3 itemOffset, List<Vector2Int> resultPositions)
		{
			return false;
		}

		public bool Contains(Vector2Int position)
		{
			return false;
		}

		public void Push(List<Vector2Int> positions)
		{
		}

		public bool Push(Vector2Int position)
		{
			return false;
		}

		public void Pop(List<Vector2Int> positions)
		{
		}

		public bool Pop(Vector2Int position)
		{
			return false;
		}

		public void Clear()
		{
		}

		private Vector2Int GetAnchor(Transform item, Vector3 itemOffset)
		{
			return default;
		}
	}
}
