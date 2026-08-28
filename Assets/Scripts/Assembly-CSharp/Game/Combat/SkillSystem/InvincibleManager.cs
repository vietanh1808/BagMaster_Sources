using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class InvincibleManager
	{
		private Dictionary<GameObject, float> _datas;

		private List<GameObject> _keysToRemove;

		public bool Has(GameObject obj)
		{
			return false;
		}

		public void Add(GameObject obj, float duration)
		{
		}

		public void Clear(bool all)
		{
		}
	}
}
