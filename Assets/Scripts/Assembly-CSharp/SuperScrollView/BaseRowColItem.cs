using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class BaseRowColItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public Image mStarIcon;

		public Text mStarCount;

		public Text mRowText;

		public Text mColumnText;

		public Text mDescText;

		public Color32 mRedStarColor;

		public Color32 mGrayStarColor;

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

		public void SetItemData(ItemData itemData, int itemIndex, int row, int column)
		{
		}
	}
}
