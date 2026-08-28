using UnityEngine;

namespace SuperScrollView
{
	public class GridViewMultiplePrefabDemoScript : MonoBehaviour
	{
		public LoopGridView mLoopGridView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private ButtonPanelGridView mButtonPanel;

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
	}
}
