namespace SuperScrollView
{
	public class SimpleItemData : ItemDataBase
	{
		public int mIndex;

		public int mParentIndex;

		public string mName;

		public override void Init(int index)
		{
		}

		public override void Init(int index, int parentIndex = -1)
		{
		}

		public override void OnIndexChanged(int index)
		{
		}

		public override void OnIndexChanged(int index, int parentIndex = -1)
		{
		}

		public override bool IsFilterMatched(string filterStr)
		{
			return false;
		}
	}
}
