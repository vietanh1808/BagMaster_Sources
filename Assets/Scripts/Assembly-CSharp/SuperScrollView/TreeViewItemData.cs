using System.Collections.Generic;

namespace SuperScrollView
{
	public class TreeViewItemData<T> where T : ItemDataBase, new()
	{
		public string mName;

		public List<T> mChildItemDataList;

		public int ChildCount => 0;

		public T AddNewItemChild(int index, int childIndex)
		{
			return null;
		}

		public T GetItemChildDataByIndex(int childIndex)
		{
			return null;
		}

		public void RefreshItemDataList(int index, int childItemCount)
		{
		}

		public void AddChild(T data)
		{
		}

		public void AddChildByIndex(int index, int childIndex, T data)
		{
		}

		public bool RemoveChildByIndex(int index, int childIndex)
		{
			return false;
		}

		public T GetChild(int index)
		{
			return null;
		}
	}
}
