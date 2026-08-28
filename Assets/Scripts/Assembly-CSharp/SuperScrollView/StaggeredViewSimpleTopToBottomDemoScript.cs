using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class StaggeredViewSimpleTopToBottomDemoScript : MonoBehaviour
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

		private Button mBackButton;

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

		private void OnBackButtonClicked()
		{
		}
	}
}
