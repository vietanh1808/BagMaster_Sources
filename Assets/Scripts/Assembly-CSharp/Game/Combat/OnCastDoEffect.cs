using System;
using System.Collections.Generic;
using Game.Combat.SkillSystem;

namespace Game.Combat
{
	public class OnCastDoEffect : SafeDisposeable, ISkillComponent
	{
		private IDisposable _listener;

		private List<EffectData> _effectDatas;

		private List<IEffect> _effects;

		public SimpleSkill Skill { get; private set; }

		public OnCastDoEffect(SimpleSkill skill)
		{
		}

		private void OnCast(SkillCastData data)
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
