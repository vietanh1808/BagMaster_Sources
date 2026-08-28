using System.Collections.Generic;

namespace Game.Combat
{
	public class EAddTag : IEffect, IEffectCancelable
	{
		private EAddTagParams _params;

		private List<IHasTags> _hasTags;

		public float Intensity { get; set; }

		public EAddTag(EAddTagParams param)
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
