using System.Collections.Generic;

namespace Game.Combat
{
	public class EStatBuff : SafeDisposeable, IEffect, IEffectCancelable
	{
		protected EStatBuffParams _params;

		protected List<StatusData> _statusDatas;

		public float Intensity { get; set; }

		public EStatBuff(EStatBuffParams param)
		{
		}

		public void Execute(IEffectTarget target)
		{
		}

		protected virtual StatusData CreateStatBuffStatus(IStatOwner target)
		{
			return null;
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
