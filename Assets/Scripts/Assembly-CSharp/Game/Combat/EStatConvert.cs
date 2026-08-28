using System.Collections.Generic;
using R3;

namespace Game.Combat
{
	public class EStatConvert : SafeDisposeable, IEffectCancelable, IEffect
	{
		private class EffectedData
		{
			public IStatHolder StatHolder;

			public StatModifier Modifier;
		}

		private EStatConvertParam _params;

		private List<EffectedData> _effectedStatHolders;

		private DisposableBag _disposableBag;

		public float Intensity { get; set; }

		public EStatConvert(EStatConvertParam convertParam)
		{
		}

		public virtual void Execute(IEffectTarget target)
		{
		}

		protected virtual bool VerifyTarget(IEffectTarget target, out IStatHolder targetStatHolder)
		{
			targetStatHolder = null;
			return false;
		}

		private StatModifier CalculateValue(Stat from, Stat to)
		{
			return default;
		}

		private void RecalculateWhenStatChanged(EffectedData data)
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
