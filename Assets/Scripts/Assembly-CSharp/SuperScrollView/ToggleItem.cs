using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ToggleItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public Text mDescText;

		public Toggle mToggle;

		private ItemData mItemData;

		private int mItemIndex;

		public void Init()
		{
		}

		private void OnToggleValueChanged(bool check)
		{
		}

		public void SetItemData(ItemData itemData, int itemIndex)
		{
		}
	}
}
