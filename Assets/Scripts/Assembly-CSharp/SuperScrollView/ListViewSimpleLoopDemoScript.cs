using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ListViewSimpleLoopDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		private Button mSetCountButton;

		private InputField mSetCountInput;

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private Button mBackButton;

		private int mCurrentSelectItemId;

		public int mLoopCount;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
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

		private void OnBackButtonClicked()
		{
		}
	}
}
