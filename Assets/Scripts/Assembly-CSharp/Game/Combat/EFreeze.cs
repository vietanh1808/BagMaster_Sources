using System.Collections.Generic;

namespace Game.Combat
{
	public class EFreeze : SafeDisposeable, IEffect, IEffectCancelable
	{
		protected EFreezeParams _params;

		private List<IFreezeable> _freezeables;

		public float Intensity { get; set; }

		public EFreeze(EFreezeParams param)
		{
		}

		public void Execute(IEffectTarget target)
		{
		}

		protected virtual bool VerifyTarget(IEffectTarget target, out IStatOwner statOwner)
		{
			statOwner = null;
			return false;
		}

		public void Cancel()
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
