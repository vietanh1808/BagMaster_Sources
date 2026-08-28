namespace SuperScrollView
{
	public class ContentFitterItemData : ItemDataBase
	{
		public int mIndex;

		public string mName;

		public override void Init(int index)
		{
		}

		public override void OnIndexChanged(int index)
		{
		}

		public override bool IsFilterMatched(string filterStr)
		{
			return false;
		}
	}
}
