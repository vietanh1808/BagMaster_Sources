using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class NestedSimpleLeftRightItem : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public Text mTitle;

		private int mIndex;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		public void Init()
		{
		}

		public void SetItemData(NestedSimpleItemData itemData)
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}
	}
}
