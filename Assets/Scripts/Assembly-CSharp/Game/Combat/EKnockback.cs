namespace Game.Combat
{
	public class EKnockback : IEffect
	{
		protected EKnockbackParams _params;

		public float Intensity { get; set; }

		public EKnockback(EKnockbackParams param)
		{
		}

		public EKnockback(IEffectCaster caster, IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter, EKnockbackParams param)
		{
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
