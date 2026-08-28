using UnityEngine;

namespace SuperScrollView
{
	public class ListViewClickLoadMoreDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private LoadingTipStatus mLoadingTipStatus;

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

		private void Update()
		{
		}

		private void OnLoadMoreButtonClicked()
		{
		}

		private void OnDataSourceLoadMoreFinished()
		{
		}
	}
}
