using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class ActivateBaseOnGearInBagComponent : ActivateBaseOnGearComponent
	{
		public ActivateBaseOnGearInBagComponent(SimpleSkill skill)
			: base(null)
		{
		}

		public override void Fetch(IReadOnlyDictionary<Vector2Int, IBagGridItem> gridMap, IReadOnlyDictionary<IBagGridItem, List<Vector2Int>> gearPlacementPoints)
		{
		}

		private List<IEffectTarget> FindTargets(bool includeSelf, IEnumerable<Gear> gears)
		{
			return null;
		}

		private bool FailCompareCondition(IEnumerable<Gear> gears)
		{
			return false;
		}

		private void Do(int triggerCount)
		{
		}
	}
}
