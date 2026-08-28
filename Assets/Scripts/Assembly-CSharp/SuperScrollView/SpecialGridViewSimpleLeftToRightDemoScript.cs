using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class SpecialGridViewSimpleLeftToRightDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		private const int mItemCountPerRow = 3;

		private int mItemPadding;

		private int mItemMinHight;

		private int mItemMaxHeight;

		private int[][] mItemHeightArray;

		private int mItemHeightCount;

		private Button mSetCountButton;

		private InputField mSetCountInput;

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private Button mAddButton;

		private Button mBackButton;

		private int mCurrentSelectItemId;

		private void Start()
		{
		}

		private void InitItemHeightArrayForDemo()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex)
		{
			return null;
		}

		private void UpdateItemHeightAndPos(SimpleItemList itemScript, int rowIndex)
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
