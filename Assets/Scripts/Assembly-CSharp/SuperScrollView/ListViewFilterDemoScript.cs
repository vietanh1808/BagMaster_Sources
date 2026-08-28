using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ListViewFilterDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private InputField mFilterClickInput;

		private Button mFilterButton;

		private InputField mFilterInput;

		private Button mSetCountButton;

		private InputField mSetCountInput;

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private Button mAddButton;

		private InputField mAddInput;

		private Button mBackButton;

		private List<ItemData> mFilteredDataList;

		private string mFilerStr;

		private string mFilerClickStr;

		private void Start()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
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
