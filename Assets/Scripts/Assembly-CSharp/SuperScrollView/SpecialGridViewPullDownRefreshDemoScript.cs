using UnityEngine;

namespace SuperScrollView
{
	public class SpecialGridViewPullDownRefreshDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private LoadingTipStatus mLoadingTipStatusForRefresh;

		private float mDataLoadedTipShowLeftTime;

		private float mLoadingTipItemHeightForRefresh;

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

		private void UpdateLoadingTipForRefresh(LoopListViewItem2 item)
		{
		}

		private void OnDraging()
		{
		}

		private void OnEndDrag()
		{
		}

		private void OnDragingForRefresh()
		{
		}

		private void OnEndDragForRefresh()
		{
		}

		private void OnDataSourceRefreshFinished()
		{
		}

		private void Update()
		{
		}
	}
}
