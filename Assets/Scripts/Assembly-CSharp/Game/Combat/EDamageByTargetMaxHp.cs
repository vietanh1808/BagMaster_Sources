namespace Game.Combat
{
	public class EDamageByTargetMaxHp : EDamage
	{
		public EDamageByTargetMaxHp(EDamageParams param)
			: base(default)
		{
		}

		public EDamageByTargetMaxHp(IEffectCaster caster, Stat.GetValueCustomDelegate statModifierFilter, EDamageParams param)
			: base(default)
		{
		}

		public EDamageByTargetMaxHp(IEffectCaster caster, IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter, EDamageParams param)
			: base(default)
		{
		}

		public override float CalculateDamage(EDamageFormula formula, EnemyController enemy, Unit player, float intensity = 1f)
		{
			return 0f;
		}
	}
}
