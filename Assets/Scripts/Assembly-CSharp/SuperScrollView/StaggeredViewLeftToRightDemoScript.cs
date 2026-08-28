using UnityEngine;

namespace SuperScrollView
{
	public class StaggeredViewLeftToRightDemoScript : MonoBehaviour
	{
		public LoopStaggeredGridView mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private int[] mItemWidthArrayForDemo;

		private float mMinWidth;

		private int mCount;

		private ButtonPanelStaggeredView mButtonPanel;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopStaggeredGridViewItem OnGetItemByIndex(LoopStaggeredGridView listView, int index)
		{
			return null;
		}

		private void InitItemWidthArray()
		{
		}
	}
}
