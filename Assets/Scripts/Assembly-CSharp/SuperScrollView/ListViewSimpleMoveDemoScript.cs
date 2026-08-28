using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ListViewSimpleMoveDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		private InputField mSetCountInput;

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private int mCurrentSelectItemId;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private (float, float) OnGetItemSizeByIndex(int itemIndex)
		{
			return default;
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		private void OnItemClicked(int itemId)
		{
		}

		private void OnScrollToButtonClicked()
		{
		}
	}
}
