using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ToggleRowColItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public Image mStarIcon;

		public Text mStarCount;

		public Text mRowText;

		public Text mColumnText;

		public Color32 mRedStarColor;

		public Color32 mGrayStarColor;

		public Toggle mToggle;

		private int mItemDataIndex;

		private ItemData mItemData;

		public void Init()
		{
		}

		private void OnToggleValueChanged(bool check)
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
