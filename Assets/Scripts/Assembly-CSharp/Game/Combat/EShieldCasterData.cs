namespace Game.Combat
{
	public struct EShieldCasterData
	{
		public IEffectCaster Caster;

		public float Proficiency;

		public float Attack;

		public static EShieldCasterData Default => default;
	}
}
