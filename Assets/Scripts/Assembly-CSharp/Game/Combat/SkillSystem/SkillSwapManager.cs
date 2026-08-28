using System.Collections.Generic;

namespace Game.Combat.SkillSystem
{
	public class SkillSwapManager
	{
		private class SkillBehaviourData
		{
			public SimpleSkill Skill;

			public SkillData Root;
		}

		private readonly Bag _bag;

		private List<SkillBehaviourData> _behaviourDatas;

		private Dictionary<SkillData, SkillData> _fromToTable;

		public SkillSwapManager(Bag bag)
		{
		}

		public void AddSkill(SimpleSkill skill, SkillData root)
		{
		}

		public void RemoveSkill(SimpleSkill skill)
		{
		}

		public SkillData GetFinal(SkillData from)
		{
			return null;
		}

		public void AddSwap(SkillData from, SkillData to)
		{
		}

		public void Clear()
		{
		}

		private void Refresh()
		{
		}

		private void RefreshSkill(SimpleSkill skill, SkillData newData)
		{
		}
	}
}
