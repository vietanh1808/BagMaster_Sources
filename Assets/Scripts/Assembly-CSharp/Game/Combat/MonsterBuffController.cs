using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class MonsterBuffController : MonoBehaviour
	{
		public List<SimpleSkill> ActivatedBuff;

		private void OnDestroy()
		{
		}
	}
}
