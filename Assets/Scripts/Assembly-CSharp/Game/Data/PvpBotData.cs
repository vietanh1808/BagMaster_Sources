using System;

namespace Game.Data
{
	[Serializable]
	public struct PvpBotData
	{
		public int BotID;

		public int GroupRankID;

		public int InitialRankPoint;

		public string RankPointEarnByInterval;

		public int RankPointCap;

		public int WeaponID;

		public int WeaponLevel;

		public int AccessoryID;

		public int AccessoryLevel;

		public int BodyID;

		public int BodyLevel;

		public int HeadID;

		public int HeadLevel;

		public int GearUpgradeConfig;

		public int HeroesConfig;

		public int Modifiers;

		public int TalentRequireLevel;

		public int ChapterReached;

		private static Random random;

		public int GetRandomPoint(int stack)
		{
			return 0;
		}
	}
}
