using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class InputFieldItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public Text mDesc;

		public InputField mInputField;

		private ItemData mItemData;

		private int mItemDataIndex;

		public void Init()
		{
		}

		public void SetItemData(ItemData itemData, int itemIndex)
		{
		}

		public void OnInputFieldValueChange(string text)
		{
		}
	}
}
