using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class PageViewSimpleDemoScript : MonoBehaviour
	{
		private class DotElem
		{
			public GameObject mDotElemRoot;

			public GameObject mDotNormal;

			public GameObject mDotSelect;
		}

		public LoopListView2 mLoopListView;

		public RectTransform mParentView;

		public RectTransform mDotsRoot;

		public RectTransform mDotTemplate;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		private Button mSetCountButton;

		private InputField mSetCountInput;

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private Button mAddButton;

		private Button mBackButton;

		private int mPageCount;

		private const int mMaxPageCount = 10;

		private List<DotElem> mDotElemList;

		private void Start()
		{
		}

		public void InitButtonPanel()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int pageIndex)
		{
			return null;
		}

		private void InitAllDots()
		{
		}

		private void CreateDots(int count)
		{
		}

		private void CreateOneDot(RectTransform rectParent, RectTransform rectTemplate)
		{
		}

		private void OnDotClicked(int index)
		{
		}

		private void UpdateAllDots()
		{
		}

		private void RefreshAllDots(int selectedIndex)
		{
		}

		private void ResetDots()
		{
		}

		private void AppendDots(int count)
		{
		}

		private void RemoveDots(int count)
		{
		}

		private void OnSnapNearestChanged(LoopListView2 listView, LoopListViewItem2 item)
		{
		}

		private void OnEndDrag()
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
