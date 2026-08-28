using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public struct SkillCreationParams
	{
		public Unit Caster;

		public Gear Gear;

		public Transform Muzzle;

		public bool HasUpdate;
	}
}
