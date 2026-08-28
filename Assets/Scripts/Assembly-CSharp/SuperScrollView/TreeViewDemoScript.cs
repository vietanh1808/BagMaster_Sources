using UnityEngine;

namespace SuperScrollView
{
	public class TreeViewDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		private TreeViewDataSourceMgr<ItemData> mTreeViewDataSourceMgr;

		private TreeViewItemCountMgr mTreeItemCountMgr;

		private ButtonPanelTreeView mButtonPanel;

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
	}
}
