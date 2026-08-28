using System.Collections.Generic;

namespace SuperScrollView
{
	public class TreeViewDataSourceMgr<T> where T : ItemDataBase, new()
	{
		private List<TreeViewItemData<T>> mItemDataList;

		private int mTreeViewItemCount;

		private int mTreeViewChildItemCountDefault;

		private static int[] mTreeViewChildItemCount;

		public int TreeViewItemCount => 0;

		public int TotalTreeViewItemAndChildCount => 0;

		public TreeViewItemData<T> GetItemDataByIndex(int index)
		{
			return null;
		}

		public T GetItemChildDataByIndex(int itemIndex, int childIndex)
		{
			return null;
		}

		public T AddNewItemChild(int itemIndex, int AddToBeforeChildIndex)
		{
			return null;
		}

		public TreeViewItemData<T> AddNewItem(int addToBeforeIndex)
		{
			return null;
		}

		public bool RemoveItem(int itemIndex)
		{
			return false;
		}

		public void AddItemChild(int itemIndex, int AddToBeforeChildIndex, T itemData)
		{
		}

		public bool RemoveItemChild(int itemIndex, int childIndex)
		{
			return false;
		}

		private void DoRefreshDataSource()
		{
		}
	}
}
