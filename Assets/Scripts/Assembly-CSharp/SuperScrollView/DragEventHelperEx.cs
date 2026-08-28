using UnityEngine;
using UnityEngine.EventSystems;

namespace SuperScrollView
{
	public class DragEventHelperEx : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		public delegate void OnDragEventHandler(PointerEventData eventData, object param);

		public OnDragEventHandler mOnBeginDragHandler;

		public OnDragEventHandler mOnDragHandler;

		public OnDragEventHandler mOnEndDragHandler;

		private object mParam;

		public object Param
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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
