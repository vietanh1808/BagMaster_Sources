using Game;

public static class ResourceExtensions
{
	public static bool IsCombatCurrency(this ResourceRewardData rewardData)
	{
		return false;
	}

	public static bool IsCombatCurrency(this ResourceRewardData rewardData, out CurrencyData currencyData)
	{
		currencyData = null;
		return false;
	}
}
