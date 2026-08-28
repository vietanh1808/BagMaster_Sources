using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class SpecifyGameObjectsFilter : IFilter
	{
		private List<GameObject> _result;

		public SpecifyGameObjectsFilter(List<GameObject> gameObjects)
		{
		}

		public List<GameObject> Find()
		{
			return null;
		}
	}
}
