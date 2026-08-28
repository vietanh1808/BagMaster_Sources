using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class SliderItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public Text mDesc;

		public Slider mSlider;

		private ItemData mItemData;

		private int mItemDataIndex;

		public void Init()
		{
		}

		public void SetItemData(ItemData itemData, int itemIndex)
		{
		}

		public void OnSliderValueChange(float value)
		{
		}
	}
}
