namespace Game.Combat
{
	public struct EDamageGearData
	{
		public float Power;

		public float Attack;

		public float CritRate;

		public float CritDamageMultiplierBonus;

		public float ElementalPenetration;

		public float ElementalDamageMulplierBonus;

		public float LifeSteal;

		public static EDamageGearData Default => default;
	}
}
