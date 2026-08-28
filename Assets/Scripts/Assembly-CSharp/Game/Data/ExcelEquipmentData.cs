using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelEquipmentData
	{
		public int Id;

		public int GroupId;

		public string NameKey;

		public string Icon;

		public string Type;

		public string Rarity;

		public int RarityLevel;

		public int MaxLevel;

		public int Passive;

		public int Upgrade;

		public int Ascend;

		public string FusionMaterials;

		public float Power;

		public int Is_S_Tier;

		public bool IsMaterial;

		public string RevertItems;

		public string TrackingName;

		public string AscendSkillDescription;

		public string SkinKey;

		public string Skin;

		public string SkinArm;

		public string EquipmentSkillPreview;
	}
}
