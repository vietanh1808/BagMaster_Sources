namespace SuperScrollView
{
	public class TreeViewItemCountData
	{
		public int mTreeItemIndex;

		public int mChildCount;

		public bool mIsExpand;

		public int mBeginIndex;

		public int mEndIndex;

		public bool IsChild(int index)
		{
			return false;
		}

		public int GetChildIndex(int index)
		{
			return 0;
		}
	}
}
