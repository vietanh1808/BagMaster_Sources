namespace SuperScrollView
{
	public class NestedSimpleItemData : ItemDataBase
	{
		public string mName;

		public int mIndex;

		public DataSourceMgr<SimpleItemData> mDataSourceMgr;

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
