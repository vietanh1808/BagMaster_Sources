using UnityEngine;

namespace Game.Combat
{
	public struct EDamageParams
	{
		public object Source;

		public float BaseDamage;

		public float LifeSteal;

		public Elemental DamageType;

		public EDamageFormula Formula;

		public EDamageAttackType AttackType;

		public bool NoCrit;

		public bool Dodgeable;

		public Vector3 Position;

		public int FloatingTextChannel;
	}
}
