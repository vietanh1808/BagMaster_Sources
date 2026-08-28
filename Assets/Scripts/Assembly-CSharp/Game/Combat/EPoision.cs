namespace Game.Combat
{
	public class EPoision : EDamage, IEffectCancelable
	{
		protected EPoisionParams _poisonParams;

		protected StatusData _statusData;

		public EPoision(EDamageParams param, EPoisionParams poisonParam)
			: base(default)
		{
		}

		public EPoision(IEffectCaster unit, Stat.GetValueCustomDelegate statModifierFilter, EDamageParams param, EPoisionParams poisonParam)
			: base(default)
		{
		}

		public EPoision(IEffectCaster unit, IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter, EDamageParams param, EPoisionParams poisonParam)
			: base(default)
		{
		}

		public override void Execute(IEffectTarget target)
		{
		}

		protected virtual StatusData CreatePoisonStatus(Unit targetUnit)
		{
			return null;
		}

		protected override void DealDamage(Unit targetUnit)
		{
		}

		public void Cancel()
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
