using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class DraggableViewTopToBottomDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<DraggableItemData> mDataSourceMgr;

		private Button mBackButton;

		private Vector2 mDragOffset;

		private float mAnimMoveSpeed;

		private float mListViewMoveSpeed;

		private float mListViewMoveVec;

		private LoopListViewItem2 mDraggingItem;

		private Camera mCachedEventCamera;

		private List<TweenHelper> mCurTweenHelperList;

		private Vector3[] mItemWorldCorners;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		public void OnBeginDragItem(PointerEventData eventData, object param)
		{
		}

		public void OnDragItem(PointerEventData eventData, object param)
		{
		}

		private void Update()
		{
		}

		public void OnEndDragItem(PointerEventData eventData, object param)
		{
		}

		private void OnTweenFinished()
		{
		}

		private void SetDraggedPosition(PointerEventData eventData, LoopListViewItem2 draggingItem)
		{
		}

		private void OnBackButtonClicked()
		{
		}
	}
}
