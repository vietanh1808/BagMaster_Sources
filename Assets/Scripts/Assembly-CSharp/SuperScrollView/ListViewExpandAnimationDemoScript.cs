using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ListViewExpandAnimationDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<SimpleExpandItemData> mDataSourceMgr;

		private Button mSetCountButton;

		private InputField mSetCountInput;

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private Button mAddButton;

		private InputField mAddInput;

		private Button mBackButton;

		private int mCurrentSelectItemId;

		public ExpandAnimationType mAnimaionType;

		private AnimationHelper mAnimationHelper;

		private Color[] mItemColorArray;

		private int mItemColorCount;

		private float mItemColorR;

		private float mItemColorG;

		private float mItemColorB;

		private const float mColorMask = 255f;

		private const float mColorRangeFrom = 0f;

		private const float mColorRangeTo = 60f;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private void InitItemColorArray()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		private void Update()
		{
		}

		private void UpdateItemColor(ExpandAnimationItem itemScript, int id)
		{
		}

		private void OnItemClicked(int itemId)
		{
		}

		private void OnSetCountButtonClicked()
		{
		}

		private void OnScrollToButtonClicked()
		{
		}

		private void OnAddButtonClicked()
		{
		}

		private void OnBackButtonClicked()
		{
		}
	}
}
