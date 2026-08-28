namespace Game.Shop
{
	public class GachaChestCostService : IGachaCostService
	{
		private readonly GachaChestService _gachaService;

		private readonly ResourceRequireData _cost;

		private readonly int _drawCount;

		public GachaChestCostService(GachaChestService gachaService, ResourceRequireData cost, int drawCount = 1)
		{
		}

		public bool IsEnough()
		{
			return false;
		}

		public int GetRequiredAmount()
		{
			return 0;
		}

		public int GetOwnedAmount()
		{
			return 0;
		}

		public void Draw()
		{
		}
	}
}
