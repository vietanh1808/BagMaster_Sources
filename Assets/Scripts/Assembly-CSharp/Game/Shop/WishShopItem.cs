using Game.StarBreaking;
using TMPro;
using UnityEngine;

namespace Game.Shop
{
	public class WishShopItem : TimePackShopItem
	{
		[Header("Wish")]
		[SerializeField]
		private TextMeshProUGUI _cardValueText;

		[SerializeField]
		private string _cardValueTextFormat;

		private StarBreakPackData _starBreakData;

		public override void Initialize(ShopPackData package)
		{
		}
	}
}
