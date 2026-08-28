namespace Game.Combat
{
	public class ESwapSkill : SafeDisposeable, IEffect, IEffectCancelable
	{
		protected ESwapSkillParams _params;

		private ISkillSwapOwner _effectedTarget;

		private bool _removed;

		public float Intensity { get; set; }

		public ESwapSkill(ESwapSkillParams param)
		{
		}

		public void Execute(IEffectTarget target)
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
