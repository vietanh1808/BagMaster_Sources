using UnityEngine;

namespace Game.Combat
{
	public class TraitShopTakeAllGemBar : MonoBehaviour, IResourceReturnValueUI
	{
		[SerializeField]
		private CurrencyView _takeAllPriceView;

		public void SetDisplayValueOffset(int value)
		{
		}
	}
}
