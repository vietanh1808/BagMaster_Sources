using UnityEngine;

namespace SuperScrollView
{
	public class NestedSimpleGridViewDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<NestedSimpleItemData> mDataSourceMgr;

		private ButtonPanelNestedSimple mButtonPanel;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}
	}
}
