using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ListViewDeleteAnimationDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		private Button mSetCountButton;

		private InputField mSetCountInput;

		private Button mScrollToButton;

		private InputField mScrollToInput;

		private Button mDeleteButton;

		private InputField mDeleteInput;

		private Button mBackButton;

		private int mCurrentSelectItemId;

		private AnimationHelper mAnimationHelper;

		public AnimationType mAnimaionType;

		public float mAnimationTime;

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

		private void UpdateItemColor(DeleteAnimationItem itemScript, int id)
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

		private void OnDeleteButtonClicked()
		{
		}

		private void OnBackButtonClicked()
		{
		}
	}
}
