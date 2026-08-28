using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class BaseVerticalLineItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public Image[] mStarArray;

		public Text mDesc;

		public Text mDescExtend;

		public Color32 mRedStarColor;

		public Color32 mGrayStarColor;

		public Image mLine;

		private ItemData mItemData;

		private int mItemDataIndex;

		public void Init()
		{
		}

		private void OnStarClicked(int index)
		{
		}

		public void SetStarCount(int count)
		{
		}

		public void SetItemData(ItemData itemData, int itemIndex)
		{
		}

		public void SetLineVisible(bool visible)
		{
		}
	}
}
