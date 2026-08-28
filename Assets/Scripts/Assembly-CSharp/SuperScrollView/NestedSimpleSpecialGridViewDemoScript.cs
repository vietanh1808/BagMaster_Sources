using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class NestedSimpleSpecialGridViewDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		private const int mItemCountPerRow = 30;

		private float mItemPadding;

		private float mItemOffsetX;

		private float mItemOffsetY;

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

		private void UpdateItemPrefab()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex)
		{
			return null;
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
