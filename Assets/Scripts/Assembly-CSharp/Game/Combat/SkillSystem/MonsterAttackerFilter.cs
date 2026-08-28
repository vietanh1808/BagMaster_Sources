using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class MonsterAttackerFilter : IFilter
	{
		private Transform _owner;

		private Stat _range;

		public MonsterAttackerFilter(Transform owner, Stat range)
		{
		}

		public List<GameObject> Find()
		{
			return null;
		}
	}
}
