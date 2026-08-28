using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ResponsiveViewDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private int mItemCountPerRow;

		private int mMinWidth;

		public DragChangSizeScript mDragChangSizeScript;

		private Button mSetCountButton;

		private InputField mSetCountInput;

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private Button mAddButton;

		private InputField mAddInput;

		private Button mBackButton;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private void UpdateItemPrefab()
		{
		}

		private void OnViewPortSizeChanged()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		private void OnSetCountButtonClicked()
		{
		}

		private void OnScrollToButtonClicked()
		{
		}

		private int GetRow(int itemCount)
		{
			return 0;
		}

		private int GetRowIndex(int itemCount)
		{
			return 0;
		}

		private void OnAddButtonClicked()
		{
		}

		private void OnBackButtonClicked()
		{
		}
	}
}
