namespace Game.Shop
{
	public interface IGachaCostService
	{
		bool IsEnough();

		int GetRequiredAmount();

		int GetOwnedAmount();

		void Draw();
	}
}
