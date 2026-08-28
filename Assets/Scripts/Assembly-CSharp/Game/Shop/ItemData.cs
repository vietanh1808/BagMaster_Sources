namespace Game.Shop
{
	public class ItemData : IHasWeight<ItemData>
	{
		public bool IsPity;

		public RewardPack RewardPack;

		public float Weight { get; set; }

		public ItemData Value => null;
	}
}
