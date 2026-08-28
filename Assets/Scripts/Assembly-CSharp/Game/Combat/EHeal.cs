namespace Game.Combat
{
	public class EHeal : IEffect
	{
		protected EHealParams _params;

		protected EHealGearData _gearData;

		protected EHealCasterData _casterData;

		protected float _calculatedHeal;

		public float Intensity { get; set; }

		public float CalculatedHealAmount => 0f;

		public EHeal(EHealParams param)
		{
		}

		public EHeal(IEffectCaster caster, IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter, EHealParams param)
		{
		}

		protected virtual void InitializeGearData(IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter)
		{
		}

		protected virtual void InitializeCasterData(IEffectCaster caster, Stat.GetValueCustomDelegate statModifierFilter)
		{
		}

		public virtual float CalculateHealPercent(float intensity)
		{
			return 0f;
		}

		public void Execute(IEffectTarget target)
		{
		}

		protected virtual bool VerifyTarget(IEffectTarget target, out Unit targetUnit)
		{
			targetUnit = null;
			return false;
		}
	}
}
