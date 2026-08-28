namespace Game.Combat
{
	public class EShield : IEffect
	{
		protected EShieldParams _params;

		protected EShieldGearData _gearData;

		protected EShieldCasterData _casterData;

		protected float _calculatedShieldAmount;

		public float Intensity { get; set; }

		public float CalculatedShieldAmount => 0f;

		public EShield(EShieldParams param)
		{
		}

		public EShield(IEffectCaster caster, IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter, EShieldParams param)
		{
		}

		protected virtual void InitializeGearData(IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter)
		{
		}

		protected virtual void InitializeCasterData(IEffectCaster caster, Stat.GetValueCustomDelegate statModifierFilter)
		{
		}

		public virtual float CalculatShieldAmount(float intensity)
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
