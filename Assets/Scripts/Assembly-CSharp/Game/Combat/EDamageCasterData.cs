namespace Game.Combat
{
	public struct EDamageCasterData
	{
		public IEffectCaster Caster;

		public float Attack;

		public float CritRate;

		public float CritDamageMultiplierBonus;

		public float ElementalPenetration;

		public float ElementalDamageMulplierBonus;

		public float LifeSteal;

		public float LifeStealOfAttackType;

		public static EDamageCasterData Default => default;
	}
}
