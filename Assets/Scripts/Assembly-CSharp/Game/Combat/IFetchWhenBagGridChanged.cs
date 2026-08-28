using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public interface IFetchWhenBagGridChanged
	{
		void Fetch(IReadOnlyDictionary<Vector2Int, IBagGridItem> gridMap, IReadOnlyDictionary<IBagGridItem, List<Vector2Int>> gearPlacementPoints);
	}
}
