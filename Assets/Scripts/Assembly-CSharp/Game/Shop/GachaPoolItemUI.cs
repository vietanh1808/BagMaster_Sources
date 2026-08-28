using TMPro;
using UnityEngine;

namespace Game.Shop
{
	public class GachaPoolItemUI : MonoBehaviour
	{
		[Header("UI Elements")]
		[SerializeField]
		private ResourceView _resourceView;

		[SerializeField]
		private TextMeshProUGUI _rateText;

		private ItemData _itemData;

		private float _rate;

		public void UpdateInfo(ItemData itemData, float rate)
		{
		}

		private void DisplayItemInfo()
		{
		}
	}
}
