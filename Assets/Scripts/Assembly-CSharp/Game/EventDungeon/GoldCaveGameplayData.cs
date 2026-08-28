using Game.Combat;

namespace Game.EventDungeon
{
	public static class GoldCaveGameplayData
	{
		public static float totalLevelMonsterHp;

		public static float totalHpDeal;

		public static int exchangeRate;

		public static int totalGold;

		private static int nextMileStoneIndex;

		private static float[] monsterHpMilestone;

		private static int[] goldCoinWillDrop;

		private static int totalCoinDropped;

		private static bool isPauseCalculate;

		public static void SetPauseCalculate(bool isPause)
		{
		}

		private static void Reset()
		{
		}

		public static int GetGoldFromCoinDropped()
		{
			return 0;
		}

		public static int GetGoldReceived()
		{
			return 0;
		}

		public static void Init()
		{
		}

		public static void OnPlayerDealDamage(Health health, float hp)
		{
		}

		private static void DropCoin(Health health, int randomCount)
		{
		}

		private static void OnCoinFinishedFly(EnemyController controller)
		{
		}
	}
}
