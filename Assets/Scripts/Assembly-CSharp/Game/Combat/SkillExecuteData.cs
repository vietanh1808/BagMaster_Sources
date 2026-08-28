using System.Collections.Generic;

namespace Game.Combat
{
	public struct SkillExecuteData
	{
		public SimpleSkill Skill;

		public bool Success;

		public IReadOnlyList<IEffectTarget> Targets;
	}
}
