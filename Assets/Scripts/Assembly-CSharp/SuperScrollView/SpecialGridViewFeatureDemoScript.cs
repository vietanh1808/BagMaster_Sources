using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class SpecialGridViewFeatureDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<ItemData> mDataSourceMgr;

		private const int mItemCountPerRow = 3;

		private Button mSetCountButton;

		private InputField mSetCountInput;

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private Button mAddButton;

		private InputField mAddInput;

		private Button mBackButton;

		private int[] mFeatureArray;

		private string[] mFeaturePrefabs;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex)
		{
			return null;
		}

		private LoopListViewItem2 NewFeatureItems(LoopListView2 listView, int rowIndex)
		{
			return null;
		}

		private LoopListViewItem2 NewMainItems(LoopListView2 listView, int rowIndex)
		{
			return null;
		}

		private int GetInitItemIndex(int rowIndex)
		{
			return 0;
		}

		private int GetInitRowIndex(int rowIndex)
		{
			return 0;
		}

		private int GetFeatureItemCount()
		{
			return 0;
		}

		private int GetFeatureLastRowIndex()
		{
			return 0;
		}

		private int GetRowIndex(int itemIndex)
		{
			return 0;
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
