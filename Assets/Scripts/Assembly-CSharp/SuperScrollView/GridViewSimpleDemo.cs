using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class GridViewSimpleDemo : MonoBehaviour
	{
		public LoopGridView mLoopGridView;

		public int mTotalDataCount;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

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

		private void InitButtonPanel()
		{
		}

		private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column)
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
