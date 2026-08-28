using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class InBagComponent : ISkillComponent, IFetchWhenBagGridChanged, ICancelWhenLeaveBagComponent
	{
		public SimpleSkill Skill { get; private set; }

		public InBagComponent(SimpleSkill skill)
		{
		}

		public void Fetch(IReadOnlyDictionary<Vector2Int, IBagGridItem> gridMap, IReadOnlyDictionary<IBagGridItem, List<Vector2Int>> gearPlacementPoints)
		{
		}

		public void Cancel()
		{
		}
	}
}
