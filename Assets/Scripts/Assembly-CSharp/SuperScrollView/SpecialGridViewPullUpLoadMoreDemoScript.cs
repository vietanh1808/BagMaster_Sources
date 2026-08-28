using UnityEngine;

namespace SuperScrollView
{
	public class SpecialGridViewPullUpLoadMoreDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private LoadingTipStatus mLoadingTipStatusForLoad;

		private float mLoadingTipItemHeightForLoad;

		public int mLoadCount;

		private int mItemCountPerRow;

		private ButtonPanelSpecialLoad mButtonPanel;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private int GetMaxRowCount()
		{
			return 0;
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex)
		{
			return null;
		}

		private void Update()
		{
		}

		private void OnDraging()
		{
		}

		private void OnEndDrag()
		{
		}

		private void UpdateLoadingTipForLoad(LoopListViewItem2 item)
		{
		}

		private void OnDragingForLoad()
		{
		}

		private void OnEndDragForLoad()
		{
		}

		private void OnDataSourceLoadMoreFinished()
		{
		}
	}
}
