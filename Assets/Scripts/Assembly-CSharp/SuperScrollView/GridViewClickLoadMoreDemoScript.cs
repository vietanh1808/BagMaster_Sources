using UnityEngine;

namespace SuperScrollView
{
	public class GridViewClickLoadMoreDemoScript : MonoBehaviour
	{
		public LoopGridView mLoopGridView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private LoadingTipStatus mLoadingTipStatus;

		public int mLoadCount;

		private ButtonPanelGridViewLoad mButtonPanel;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column)
		{
			return null;
		}

		private void UpdateLoadingTip(LoopGridViewItem item)
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
