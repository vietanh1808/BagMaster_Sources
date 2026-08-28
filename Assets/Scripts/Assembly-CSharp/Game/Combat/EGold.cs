namespace Game.Combat
{
	public class EGold : IEffect
	{
		protected EGoldParams _params;

		protected EGoldGearData _gearData;

		protected float _calculatedGoldAmount;

		public float Intensity { get; set; }

		public EGold(EGoldParams param)
		{
		}

		public EGold(IEffectCaster caster, IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter, EGoldParams param)
		{
		}

		protected virtual void InitializeGearData(IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter)
		{
		}

		public virtual float CalculateGoldAmount(float intensity)
		{
			return 0f;
		}

		public void Execute(IEffectTarget target)
		{
		}
	}
}
