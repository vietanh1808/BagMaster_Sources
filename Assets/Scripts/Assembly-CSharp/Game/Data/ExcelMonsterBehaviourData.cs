using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelMonsterBehaviourData
	{
		public int Id;

		public int Phase;

		public int Piority;

		public string Condition;

		public string ConditionParams;

		public string Action;

		public string ActionParams;

		public float InitialDelay;

		public float Cooldown;

		public float RecoveryTime;

		public string ActiveAnimation;

		public float SwingTime;
	}
}
