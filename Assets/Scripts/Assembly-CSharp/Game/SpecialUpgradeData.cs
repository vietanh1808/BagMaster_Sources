using System.Collections.Generic;
using Game.Combat.SkillSystem;

namespace Game
{
	public class SpecialUpgradeData
	{
		public int Id;

		public int EquipmentId;

		public int LevelUnlock;

		public int SkillId;

		public List<ResourceRequireData> UpgradeRequires;

		private SkillData _skillData;

		public SkillData SkillData => null;
	}
}
