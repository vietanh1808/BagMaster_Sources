namespace SuperScrollView
{
	public class ItemDataBase
	{
		private static int mItemDataTotalCount;

		public int mId;

		public virtual void Init(int index)
		{
		}

		public virtual void Init(int index, int parentIndex)
		{
		}

		public virtual void OnIndexChanged(int index)
		{
		}

		public virtual void OnIndexChanged(int index, int parentIndex)
		{
		}

		public virtual bool IsFilterMatched(string filterStr)
		{
			return false;
		}
	}
}
