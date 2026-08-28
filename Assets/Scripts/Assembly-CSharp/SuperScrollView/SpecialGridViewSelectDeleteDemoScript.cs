using UnityEngine;

namespace SuperScrollView
{
	public class SpecialGridViewSelectDeleteDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private const int mItemCountPerRow = 3;

		private ButtonPanelSpecialDelete mButtonPanel;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex)
		{
			return null;
		}
	}
}
