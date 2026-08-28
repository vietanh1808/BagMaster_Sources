using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class OneDirectionDragHelper : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler
	{
		private ScrollRect scrollRect;

		private bool isHorizontal;

		private bool isVertical;

		private void Awake()
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
