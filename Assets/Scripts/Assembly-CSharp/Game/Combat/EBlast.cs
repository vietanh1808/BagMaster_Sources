namespace Game.Combat
{
	public class EBlast : EDamage
	{
		protected EBlastParams _blastParams;

		protected EBlastCasterData _blastCasterData;

		protected EBlastGearData _blastGearData;

		public EBlast(EDamageParams param, EBlastParams blastParam)
			: base(default)
		{
		}

		public EBlast(IEffectCaster unit, Stat.GetValueCustomDelegate statModifierFilter, EDamageParams param, EBlastParams blastParam)
			: base(default)
		{
		}

		public EBlast(IEffectCaster unit, IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter, EDamageParams param, EBlastParams blastParam)
			: base(default)
		{
		}

		protected override void InitializeCasterData(IEffectCaster caster, Stat.GetValueCustomDelegate statModifierFilter)
		{
		}

		protected override void InitializeGearData(IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter)
		{
		}

		public override void Execute(IEffectTarget target)
		{
		}
	}
}
