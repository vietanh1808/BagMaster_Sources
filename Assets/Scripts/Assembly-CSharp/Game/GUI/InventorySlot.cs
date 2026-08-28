using UnityEngine;
using UnityEngine.EventSystems;

namespace Game.GUI
{
	public class InventorySlot : MonoBehaviour, IDropHandler, IEventSystemHandler
	{
		public virtual void OnDrop(PointerEventData eventData)
		{
		}
	}
}
