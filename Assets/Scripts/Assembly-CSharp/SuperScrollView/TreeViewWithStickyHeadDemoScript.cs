using UnityEngine;

namespace SuperScrollView
{
	public class TreeViewWithStickyHeadDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		private TreeViewDataSourceMgr<ItemData> mTreeViewDataSourceMgr;

		private TreeViewItemCountMgr mTreeItemCountMgr;

		public TreeViewItemHead mStickeyHeadItem;

		private RectTransform mStickeyHeadItemRf;

		private float mStickeyHeadItemHeight;

		private ButtonPanelTreeViewSticky mButtonPanel;

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

		private void UpdateStickeyHeadPos()
		{
		}

		private void OnScrollContentPosChanged(Vector2 pos)
		{
		}
	}
}
