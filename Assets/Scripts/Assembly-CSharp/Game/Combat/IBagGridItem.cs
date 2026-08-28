using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public interface IBagGridItem
	{
		bool InBag { get; }

		bool WasInBag { get; }

		bool Placeable { get; }

		Transform Transform { get; }

		Vector2Int[] PlacementPoints { get; }

		Vector2Int[] DraggingGridPoints { get; }

		Vector2 Offset { get; }

		void OnDrop();

		List<SimpleSkill> GetSkills();

		void CancelEffects();

		void FeedbackIfAnyNearPassiveActivted(IBagGridItem nearbyItem);

		void FetchPassiveOnGridChanged(IReadOnlyDictionary<Vector2Int, IBagGridItem> gridMap, IReadOnlyDictionary<IBagGridItem, List<Vector2Int>> gearPlacementPoints);

		Vector2Int GetGridAnchorPosition(Transform overrideContainer = null);

		void StartMovePosition();

		void EndMovePosition();
	}
}
