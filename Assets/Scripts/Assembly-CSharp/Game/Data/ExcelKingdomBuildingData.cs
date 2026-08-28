using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelKingdomBuildingData
	{
		public int Id;

		public string Passive_Skill_ID;

		public float[] STAT;

		public string Asset;

		public string Name;

		public string Description;

		public string SynercyDescription;

		public string Grid;

		public string Rarity;

		public string Tags;

		public string Off_Set;

		public string PressSfx;

		public string PlaceSfx;

		public string MergeAppearVfx;

		public string MarkPosition;
	}
}
