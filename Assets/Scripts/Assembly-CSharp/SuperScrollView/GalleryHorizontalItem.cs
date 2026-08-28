using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class GalleryHorizontalItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public Image mStarIcon;

		public Text mStarCount;

		public Text mDesc;

		public Color32 mRedStarColor;

		public Color32 mGrayStarColor;

		public GameObject mContentRootObj;

		private ItemData mItemData;

		private int mItemDataIndex;

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
	}
}
