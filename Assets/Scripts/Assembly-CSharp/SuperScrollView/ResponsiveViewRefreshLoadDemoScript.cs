using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ResponsiveViewRefreshLoadDemoScript : MonoBehaviour
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

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private Button mBackButton;

		private int mItemCountPerRow;

		public DragChangSizeScript mDragChangSizeScript;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private void UpdateItemPrefab()
		{
		}

		private void OnViewPortSizeChanged()
		{
		}

		private int GetMaxRowCount()
		{
			return 0;
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int row)
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

		private void OnScrollToButtonClicked()
		{
		}

		private int GetRow(int itemCount)
		{
			return 0;
		}

		private int GetRowIndex(int itemCount)
		{
			return 0;
		}

		private void OnBackButtonClicked()
		{
		}
	}
}
