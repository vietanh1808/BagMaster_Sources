namespace SuperScrollView
{
	public class NestedItemData : ItemDataBase
	{
		public string mName;

		public int mIndex;

		public DataSourceMgr<ItemData> mDataSourceMgr;

		private int mNestedCount;

		private static int[] mUseCount;

		public override void Init(int index)
		{
		}

		public override void OnIndexChanged(int index)
		{
		}
	}
}
