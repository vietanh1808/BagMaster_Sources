namespace Game.Combat
{
	public class EDamageByMaxHp : EDamage
	{
		public EDamageByMaxHp(EDamageParams param)
			: base(default)
		{
		}

		public EDamageByMaxHp(IEffectCaster caster, Stat.GetValueCustomDelegate statModifierFilter, EDamageParams param)
			: base(default)
		{
		}

		public EDamageByMaxHp(IEffectCaster caster, IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter, EDamageParams param)
			: base(default)
		{
		}

		public override float CalculateDamage(EDamageFormula formula, EnemyController enemy, Unit player, float intensity = 1f)
		{
			return 0f;
		}
	}
}
