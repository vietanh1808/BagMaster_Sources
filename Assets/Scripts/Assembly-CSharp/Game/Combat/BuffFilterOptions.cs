using System.Collections.Generic;
using Game.Constant;

namespace Game.Combat
{
	public struct BuffFilterOptions
	{
		public Rarity? Rarity;

		public IList<int> PriorityGroupIds;

		public readonly bool IsSatisfiedBy(BuffData buff)
		{
			return false;
		}
	}
}
