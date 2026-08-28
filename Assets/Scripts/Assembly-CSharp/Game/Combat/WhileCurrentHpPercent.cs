using System;

namespace Game.Combat
{
	public class WhileCurrentHpPercent : SafeDisposeable, ISkillComponent
	{
		private IDisposable _listener;

		private CompareType _compareType;

		private float _compareValue;

		public SimpleSkill Skill { get; private set; }

		private bool Condition => false;

		public WhileCurrentHpPercent(SimpleSkill skill)
		{
		}

		private void Do(bool condition)
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
