using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class ActivateBaseOnGearNearbyComponent : ActivateBaseOnGearComponent
	{
		private Dictionary<IEffectTarget, int> _targetEffectCount;

		private IReadOnlyDictionary<Vector2Int, IBagGridItem> _gridMap;

		public TargetFinderGearNearby TargetFinderGearNearby { get; private set; }

		public bool Activated { get; protected set; }

		public ActivateBaseOnGearNearbyComponent(SimpleSkill skill)
			: base(null)
		{
		}

		public override void Fetch(IReadOnlyDictionary<Vector2Int, IBagGridItem> gridMap, IReadOnlyDictionary<IBagGridItem, List<Vector2Int>> gearPlacementPoints)
		{
		}

		private void DoIfTargetSelf()
		{
		}

		private void DoIfTargetOtherGears()
		{
		}

		private void AddOrRemoveGear(IEffectTarget effectTarget, bool addMore)
		{
		}

		private void ClearEffectCount()
		{
		}

		public override void Cancel()
		{
		}
	}
}
