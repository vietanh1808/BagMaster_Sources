using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.GearUpgrade
{
	public class CurrencyPriceView : MonoBehaviour
	{
		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TextMeshProUGUI _text;

		public void UpdateInfo(Sprite icon, string text)
		{
		}

		public void UpdateInfo(string iconName, string text)
		{
		}
	}
}
