using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class NestedSimpleGridViewTopBottomItem : MonoBehaviour
	{
		public LoopGridView mLoopGridView;

		public Text mTitle;

		private int mIndex;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		public void Init()
		{
		}

		public void SetItemData(NestedSimpleItemData itemData)
		{
		}

		private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int itemIndex, int row, int column)
		{
			return null;
		}
	}
}
