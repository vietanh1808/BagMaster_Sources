using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class UnitSelfFilter : IFilter
	{
		private Unit _owner;

		public UnitSelfFilter(Unit owner)
		{
		}

		public List<GameObject> Find()
		{
			return null;
		}
	}
}
