using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class TreeViewItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public Image[] mStarArray;

		public Text mDesc;

		public Text mDescExtend;

		public Color32 mRedStarColor;

		public Color32 mGrayStarColor;

		private int mItemDataIndex;

		private int mChildDataIndex;

		private ItemData mItemData;

		public void Init()
		{
		}

		private void OnStarClicked(int index)
		{
		}

		public void SetStarCount(int count)
		{
		}

		public void SetItemData(ItemData itemData, int itemIndex, int childIndex)
		{
		}
	}
}
