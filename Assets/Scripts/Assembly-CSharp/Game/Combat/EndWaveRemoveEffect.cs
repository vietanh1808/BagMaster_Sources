using System;

namespace Game.Combat
{
	public class EndWaveRemoveEffect : SafeDisposeable, ISkillComponent
	{
		private IDisposable _endWaveListener;

		public EndWaveRemoveEffect(SimpleSkill skill)
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
