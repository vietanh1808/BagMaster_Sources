namespace Game.Shop
{
	public class CardMonthlyPackItem : SubscriptionNDailyBonusPackItem
	{
		public override int GetPackId()
		{
			return 0;
		}

		public override string GetDailyRewardPlacement()
		{
			return null;
		}
	}
}
