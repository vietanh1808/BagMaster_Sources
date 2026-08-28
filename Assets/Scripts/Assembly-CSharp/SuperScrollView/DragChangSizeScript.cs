using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SuperScrollView
{
	public class DragChangSizeScript : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler
	{
		private bool mIsDragging;

		public Camera mCamera;

		public float mBorderSize;

		public Texture2D mCursorTexture;

		public Vector2 mCursorHotSpot;

		public bool mIsVertical;

		private RectTransform mCachedRectTransform;

		private RectTransform mRootCanvasRectTransform;

		private float mMinWidth;

		private float mMinHeight;

		public Action mOnDragBeginAction;

		public Action mOnDraggingAction;

		public Action mOnDragEndAction;

		public RectTransform CachedRectTransform => null;

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		private void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
		{
		}

		private Canvas GetRootCanvas()
		{
			return null;
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}
	}
}
