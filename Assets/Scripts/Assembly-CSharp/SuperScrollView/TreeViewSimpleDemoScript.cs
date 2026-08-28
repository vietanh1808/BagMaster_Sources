using UnityEngine;

namespace SuperScrollView
{
	public class TreeViewSimpleDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		private TreeViewDataSourceMgr<SimpleItemData> mTreeViewDataSourceMgr;

		private TreeViewItemCountMgr mTreeItemCountMgr;

		private ButtonPanelTreeViewSimple mButtonPanel;

		private int mCurrentSelectItemIndex;

		private int mCurrentSelectIndex;

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

		public void OnExpandClicked(int index)
		{
		}

		private void OnItemClicked(int index, int childIndex)
		{
		}
	}
}
