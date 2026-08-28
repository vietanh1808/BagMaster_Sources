using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class StaggeredViewMoveToItemDemoScript : MonoBehaviour
	{
		public LoopStaggeredGridView mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		private int[] mItemHeightArrayForDemo;

		private int mCount;

		private float mMinHeight;

		private int mCurrentSelectItemId;

		private Button mSetCountButton;

		private InputField mSetCountInput;

		private Button mAddButton;

		private Button mMoveToButton;

		private InputField mMoveToInput;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopStaggeredGridViewItem OnGetItemByIndex(LoopStaggeredGridView listView, int index)
		{
			return null;
		}

		private (float, float) OnGetItemSizeByIndex(int itemIndex)
		{
			return default;
		}

		private void InitItemHeightArrayForDemo()
		{
		}

		private void OnItemClicked(int itemId)
		{
		}

		private void OnSetCountButtonClicked()
		{
		}

		private void OnAddButtonClicked()
		{
		}

		private void OnMoveToItemButtonClicked()
		{
		}
	}
}
