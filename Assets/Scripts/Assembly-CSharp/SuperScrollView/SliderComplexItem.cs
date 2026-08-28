using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class SliderComplexItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public Image mStarIcon;

		public Text mStarCount;

		public Text mDesc;

		public Slider mSlider;

		public Color32 mRedStarColor;

		public Color32 mGrayStarColor;

		private int mItemDataIndex;

		private ItemData mItemData;

		public void Init()
		{
		}

		private void OnStarClicked(GameObject obj)
		{
		}

		public void SetStarCount(int count)
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
