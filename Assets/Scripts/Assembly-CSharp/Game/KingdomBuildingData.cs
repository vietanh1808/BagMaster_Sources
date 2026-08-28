using Game.Combat;
using Game.Constant;
using UnityEngine;

namespace Game
{
	public class KingdomBuildingData
	{
		public int Id;

		public int[] PassiveSkillIds;

		public string IconName;

		public string Name;

		public string Description;

		public string SynercyDescription;

		public GearGridData GridData;

		public Rarity Rarity;

		public string[] Tags;

		public Vector2 DraggingOffset;

		public string PressSfx;

		public string PlaceSfx;

		public string MergeAppearVfx;

		public Vector2Int MarkPosition;

		public string LocalizedName => null;

		public string LocalizedDescription => null;

		public string LocalizedSynercyDescription => null;
	}
}
