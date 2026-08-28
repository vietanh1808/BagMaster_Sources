using UnityEngine;
using UnityEngine.EventSystems;

namespace SuperScrollView
{
	public class DragEventHelper : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		public delegate void OnDragEventHandler(PointerEventData eventData);

		public OnDragEventHandler mOnBeginDragHandler;

		public OnDragEventHandler mOnDragHandler;

		public OnDragEventHandler mOnEndDragHandler;

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
