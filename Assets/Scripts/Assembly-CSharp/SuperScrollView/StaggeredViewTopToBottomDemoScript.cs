using UnityEngine;

namespace SuperScrollView
{
	public class StaggeredViewTopToBottomDemoScript : MonoBehaviour
	{
		public LoopStaggeredGridView mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private int[] mItemHeightArrayForDemo;

		private float mMinHeight;

		private int mCount;

		private ButtonPanelStaggeredView mButtonPanel;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopStaggeredGridViewItem OnGetItemByItemIndex(LoopStaggeredGridView listView, int index)
		{
			return null;
		}

		private void InitItemHeightArrayForDemo()
		{
		}
	}
}
