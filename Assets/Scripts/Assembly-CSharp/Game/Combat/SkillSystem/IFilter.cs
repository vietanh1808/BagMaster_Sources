using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public interface IFilter
	{
		List<GameObject> Find();
	}
}
