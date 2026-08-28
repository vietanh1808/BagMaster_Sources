using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class BaseHorizontalToggleItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public Image mStarIcon;

		public Text mStarCount;

		public Text mDesc;

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

		public void SetItemData(ItemData itemData, int itemIndex)
		{
		}
	}
}
