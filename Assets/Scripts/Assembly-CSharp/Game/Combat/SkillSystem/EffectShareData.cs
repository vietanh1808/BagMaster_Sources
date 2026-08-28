using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class EffectShareData
	{
		public Unit Caster;

		public IEffectGear Gear;

		public MonoBehaviour Skill;

		public EffectRecord Record;

		public bool IsMelee;

		public float Angle;

		public GameObject ProjectileObject;
	}
}
