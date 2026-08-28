using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class DraggableVerticalItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mIcon;

		public GameObject mDragBar;

		private CanvasGroup mCanvasGroup;

		private DraggableItemData mItemData;

		private int mItemDataIndex;

		public void Init()
		{
		}

		public void SetItemData(DraggableItemData itemData, int itemIndex)
		{
		}
	}
}
