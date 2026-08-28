using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class DraggableViewFadeLeftToRightDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<DraggableItemData> mDataSourceMgr;

		private Button mBackButton;

		private Vector2 mDragOffset;

		private float mListViewMoveVec;

		private LoopListViewItem2 mDraggingItem;

		private Camera mCachedEventCamera;

		private float mDragAlpha;

		private float mListViewMoveSpeed;

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

		private void SetDraggedPosition(PointerEventData eventData, LoopListViewItem2 draggingItem)
		{
		}

		private void OnBackButtonClicked()
		{
		}
	}
}
