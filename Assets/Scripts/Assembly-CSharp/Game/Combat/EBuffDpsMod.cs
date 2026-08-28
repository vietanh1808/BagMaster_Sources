using System.Collections.Generic;

namespace Game.Combat
{
	public class EBuffDpsMod : IEffect, IEffectCancelable
	{
		protected EBuffDpsModParams _params;

		private List<IHasBuffDpsMod> _hasBuffDpsMods;

		public float Intensity { get; set; }

		public EBuffDpsMod(EBuffDpsModParams param)
		{
		}

		public void Execute(IEffectTarget target)
		{
		}

		public void Cancel()
		{
		}
	}
}
