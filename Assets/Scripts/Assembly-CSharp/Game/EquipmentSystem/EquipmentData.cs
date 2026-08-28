using Game.Combat.SkillSystem;

namespace Game.EquipmentSystem
{
	public class EquipmentData : ResourceEntityHasVisual
	{
		public int GroupId;

		public EquipmentPart Type;

		public int RarityLevel;

		public int MaxLevel;

		public SkillData PassiveSkill;

		public int UpgradeId;

		public int AscendId;

		public string AscendSkillDescription;

		public int[] FusionIds;

		public bool Fuseable;

		public int FuseMaterialRequireCount;

		public float Power;

		public int Tier;

		public bool IsMaterial;

		public RewardPack RevertItems;

		public string TrackingName;

		public string SkinKey;

		public string Skin;

		public string SkinArm;

		public string EquipmentSkillPreview;

		private EquipmentData[] _group;

		private SkillData[] _passive;

		private EquipmentData _next;

		private EquipmentUpgradeData _upgradeData;

		private bool _nextFound;

		public string LocalizedAscendSkillDescription => null;

		public bool IsRevertable => false;

		public int CompareRarity => 0;

		public bool HasDetailedInfo => false;

		public string InfoPopupName => null;

		public string InfoModalName => null;

		public EquipmentData[] Group => null;

		public SkillData[] Passives => null;

		public EquipmentData Next => null;

		public EquipmentUpgradeData UpgradeData => null;

		public EquipmentData(int id)
			: base(0)
		{
		}

		public float GetBaseStatMod()
		{
			return 0f;
		}
	}
}
