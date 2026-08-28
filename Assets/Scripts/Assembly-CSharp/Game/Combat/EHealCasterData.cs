namespace Game.Combat
{
	public struct EHealCasterData
	{
		public IEffectCaster Caster;

		public float Proficiency;

		public float Attack;

		public static EHealCasterData Default => default;
	}
}
