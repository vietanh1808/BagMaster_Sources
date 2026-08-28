using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class NestedTopBottomItem : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public Text mTitle;

		private int mIndex;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		public void Init()
		{
		}

		public void SetItemData(NestedItemData itemData)
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}
	}
}
