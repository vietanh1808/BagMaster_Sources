using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class GridViewSimpleFilterDemoScript : MonoBehaviour
	{
		public LoopGridView mLoopGridView;

		public int mTotalDataCount;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		private InputField mFilterClickInput;

		private Button mFilterButton;

		private InputField mFilterInput;

		private Button mSetCountButton;

		private InputField mSetCountInput;

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private Button mAddButton;

		private Button mBackButton;

		private int mCurrentSelectItemId;

		private List<SimpleItemData> mFilteredDataList;

		private string mFilerStr;

		private string mFilerClickStr;

		private void Start()
		{
		}

		private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column)
		{
			return null;
		}

		private void OnItemClicked(int itemId)
		{
		}

		private void OnFilterButtonClicked()
		{
		}

		private void OnInputChanged(string value)
		{
		}

		private void UpdateFilteredDataList(string filterStr)
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
