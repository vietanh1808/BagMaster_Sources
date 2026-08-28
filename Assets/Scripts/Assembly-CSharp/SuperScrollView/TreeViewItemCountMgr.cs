using System.Collections.Generic;

namespace SuperScrollView
{
	public class TreeViewItemCountMgr
	{
		private List<TreeViewItemCountData> mTreeItemDataList;

		private TreeViewItemCountData mLastQueryResult;

		private bool mIsDirty;

		public int TreeViewItemCount => 0;

		public void AddTreeItem(int count, bool isExpand)
		{
		}

		public void AddTreeItemBeforeIndex(int addBeforeIndex, int count, bool isExpand)
		{
		}

		public void Clear()
		{
		}

		public void RemoveTreeItem(int itemIndex)
		{
		}

		public TreeViewItemCountData GetTreeItem(int treeIndex)
		{
			return null;
		}

		public void SetItemChildCount(int treeIndex, int count)
		{
		}

		public void AddItemChildCount(int treeIndex, int addCount)
		{
		}

		public void SetItemExpand(int treeIndex, bool isExpand)
		{
		}

		public void ToggleItemExpand(int treeIndex)
		{
		}

		public bool IsTreeItemExpand(int treeIndex)
		{
			return false;
		}

		private void UpdateAllTreeItemDataIndex()
		{
		}

		public int GetTotalItemAndChildCount()
		{
			return 0;
		}

		public TreeViewItemCountData QueryTreeItemByTotalIndex(int totalIndex)
		{
			return null;
		}
	}
}
