using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class SpecialGridViewSimpleTopToBottomDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		private const int mItemCountPerRow = 3;

		private int mItemPadding;

		private int mItemMinWidth;

		private int mItemMaxWidth;

		private Button mSetCountButton;

		private InputField mSetCountInput;

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private Button mAddButton;

		private Button mBackButton;

		private int mCurrentSelectItemId;

		private int[][] mItemWidthArray;

		private int mItemWidthCount;

		private void Start()
		{
		}

		private void InitItemWidthArray()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex)
		{
			return null;
		}

		private void UpdateItemWidthAndPos(SimpleItemList itemScript, int rowIndex)
		{
		}

		private void OnItemClicked(int itemId)
		{
		}

		private void OnSetCountButtonClicked()
		{
		}

		private void OnScrollToButtonClicked()
		{
		}

		private void OnAddButtonClicked()
		{
		}

		private void OnBackButtonClicked()
		{
		}
	}
}
