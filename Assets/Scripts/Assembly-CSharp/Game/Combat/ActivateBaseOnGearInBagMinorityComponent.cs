using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class ActivateBaseOnGearInBagMinorityComponent : ActivateBaseOnGearComponent
	{
		protected string[] _onlyTags;

		public ActivateBaseOnGearInBagMinorityComponent(SimpleSkill skill)
			: base(null)
		{
		}

		public override void Fetch(IReadOnlyDictionary<Vector2Int, IBagGridItem> gridMap, IReadOnlyDictionary<IBagGridItem, List<Vector2Int>> gearPlacementPoints)
		{
		}

		private bool FailCompareCondition(IEnumerable<Gear> gears)
		{
			return false;
		}

		private void Do()
		{
		}
	}
}
