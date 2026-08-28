using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class SelfGearFilter : IFilter
	{
		private GameObject _container;

		private List<GameObject> _targets;

		public SelfGearFilter(GameObject container)
		{
		}

		public List<GameObject> Find()
		{
			return null;
		}
	}
}
