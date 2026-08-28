namespace SuperScrollView
{
	public class ItemData : ItemDataBase
	{
		public int mIndex;

		public int mParentIndex;

		public string mName;

		public string mDesc;

		public string mDescExtend;

		public string mIcon;

		public int mStarCount;

		public bool mChecked;

		public bool mIsExpand;

		public float mSliderValue;

		public string mInputFieldText;

		public string mContentImage;

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
