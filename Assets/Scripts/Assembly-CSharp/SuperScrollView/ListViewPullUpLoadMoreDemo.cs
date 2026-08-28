using UnityEngine;

namespace SuperScrollView
{
	public class ListViewPullUpLoadMoreDemo : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private LoadingTipStatus mLoadingTipStatus;

		private float mLoadingTipItemHeight;

		public int mLoadCount;

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

		private void UpdateLoadingTip(LoopListViewItem2 item)
		{
		}

		private void OnBeginDrag()
		{
		}

		private void OnDraging()
		{
		}

		private void OnEndDrag()
		{
		}

		private void OnDataSourceLoadMoreFinished()
		{
		}

		private void Update()
		{
		}
	}
}
