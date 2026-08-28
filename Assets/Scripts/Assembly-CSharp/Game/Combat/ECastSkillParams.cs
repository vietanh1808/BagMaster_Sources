using Game.Combat.SkillSystem;
using UnityEngine;

namespace Game.Combat
{
	public struct ECastSkillParams
	{
		public SkillData SkillData;

		public float Duration;

		public bool UseTargetOfParent;

		public Unit Caster;

		public IEffectGear Gear;

		public Transform Muzzle;
	}
}
