using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class CurrencyView : MonoBehaviour
	{
		public Image RarityImg;

		public Image Icon;

		public TextMeshProUGUI ValueTxt;

		public string ValueFormat;

		[SerializeField]
		private GameObject fpTag;

		public ResourceEntityHasVisual Data { get; private set; }

		public int Value { get; private set; }

		public void ShowFpTag(bool value)
		{
		}

		public void UpdateInfo(ResourceEntityHasVisual data, int value)
		{
		}

		public void UpdateInfo(int resId, int value)
		{
		}

		public void SetValue(int value)
		{
		}
	}
}
