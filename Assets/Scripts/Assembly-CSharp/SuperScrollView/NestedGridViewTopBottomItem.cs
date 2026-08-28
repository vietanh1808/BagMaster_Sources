using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class NestedGridViewTopBottomItem : MonoBehaviour
	{
		public LoopGridView mLoopGridView;

		public Text mTitle;

		private int mIndex;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		public void Init()
		{
		}

		public void SetItemData(NestedItemData itemData)
		{
		}

		private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int itemIndex, int row, int column)
		{
			return null;
		}
	}
}
