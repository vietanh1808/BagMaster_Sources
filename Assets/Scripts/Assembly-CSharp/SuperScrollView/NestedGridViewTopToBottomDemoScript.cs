using UnityEngine;

namespace SuperScrollView
{
	public class NestedGridViewTopToBottomDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<NestedItemData> mDataSourceMgr;

		private ButtonPanelNested mButtonPanel;

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
