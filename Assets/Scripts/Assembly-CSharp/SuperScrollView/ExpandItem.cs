using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ExpandItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public Image[] mStarArray;

		public Text mDesc;

		public GameObject mExpandContentRoot;

		public Text mClickTip;

		public Button mExpandButton;

		public Color32 mRedStarColor;

		public Color32 mGrayStarColor;

		private bool mIsExpand;

		private int mItemDataIndex;

		private ItemData mItemData;

		public void Init()
		{
		}

		public void OnExpandChanged()
		{
		}

		private void OnExpandButtonClicked()
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
	}
}
