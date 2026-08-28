using UnityEngine.Events;

namespace Game.Shop
{
	public interface IShopItem
	{
		UnityEvent OnClaimedEvent { get; }

		ShopPackData PackageData { get; }

		void Initialize(ShopPackData package);

		void SetInteractable(bool interactable);
	}
}
