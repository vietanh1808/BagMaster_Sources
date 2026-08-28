using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Game.Combat
{
	public class BagGridMap
	{
		[CompilerGenerated]
		private Action<IBagGridItem, Vector2Int[]> m_OnItemAddedEvent;

		[CompilerGenerated]
		private Action<IBagGridItem> m_OnItemRemovedEvent;

		private Dictionary<Vector2Int, IBagGridItem> _map;

		private Dictionary<IBagGridItem, List<Vector2Int>> _itemPositions;

		public IReadOnlyDictionary<Vector2Int, IBagGridItem> Map => null;

		public IReadOnlyDictionary<IBagGridItem, List<Vector2Int>> ItemPositions => null;

		public IReadOnlyCollection<IBagGridItem> Items => null;

		public IReadOnlyCollection<Vector2Int> UnlockedPositions => null;

		public event Action<IBagGridItem, Vector2Int[]> OnItemAddedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IBagGridItem> OnItemRemovedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Copy(BagGridMap other)
		{
		}

		public bool IsUnlocked(Vector2Int position)
		{
			return false;
		}

		public void UnlockPosition(Vector2Int position)
		{
		}

		public bool TryGetItemAt(Vector2Int position, out IBagGridItem item)
		{
			item = null;
			return false;
		}

		public HashSet<IBagGridItem> GetOverlappingItems(IBagGridItem item)
		{
			return null;
		}

		public IReadOnlyList<Vector2Int> GetPositions(IBagGridItem item)
		{
			return null;
		}

		public void PlaceItem(IBagGridItem item, Vector2Int[] positions)
		{
		}

		public void PlaceItem(IBagGridItem item)
		{
		}

		public void RemoveItem(IBagGridItem item)
		{
		}
	}
}
