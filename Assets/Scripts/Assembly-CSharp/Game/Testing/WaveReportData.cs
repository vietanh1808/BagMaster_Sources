using System;

namespace Game.Testing
{
	[Serializable]
	public class WaveReportData
	{
		public int ScenarioIndex;

		public int Loop;

		public int CampaginId;

		public int Wave;

		public float PlayerCurrentHp;

		public float PlayerShieldGained;

		public float PlayerMaxHealth;

		public float PlayerAttack;

		public float PlayerCp;

		public float PlayingTime;
	}
}
