using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelPvpCombatData
	{
		public int Match_ID;

		public string Player1_Position;

		public string Player2_Position;

		public string InitGearsLayout;

		public string BuffID;

		public string RandomGearPool;

		public int GearGivenPerWave;

		public string Player1_SkillID;

		public string Player2_SkillID;

		public string InGameBackground;
	}
}
