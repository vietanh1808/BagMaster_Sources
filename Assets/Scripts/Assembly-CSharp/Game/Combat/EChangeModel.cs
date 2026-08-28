using System.Collections.Generic;

namespace Game.Combat
{
	public class EChangeModel : SafeDisposeable, IEffect, IEffectCancelable
	{
		private EChangeModelParams _params;

		private HashSet<StatusData> _statusDatas;

		public float Intensity { get; set; }

		public EChangeModel(EChangeModelParams param)
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
