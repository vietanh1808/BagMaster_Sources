using UnityEngine;

namespace SuperScrollView
{
	public class ListViewPullDownRefreshOrPullUpLoadDemo : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private LoadingTipStatus mLoadingTipStatusForRefresh;

		private LoadingTipStatus mLoadingTipStatusForLoad;

		private float mDataLoadedTipShowLeftTime;

		private float mLoadingTipItemHeightForRefresh;

		private float mLoadingTipItemHeightForLoad;

		private int mLoadMoreCount;

		private ButtonPanelLoad mButtonPanel;

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
