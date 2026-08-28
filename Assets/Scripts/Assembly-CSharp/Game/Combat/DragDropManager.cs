using UnityEngine;

namespace Game.Combat
{
	public class DragDropManager : MonoBehaviour
	{
		[SerializeField]
		private LayerMask _itemLayerMask;

		[SerializeField]
		private Camera _cam;

		private DragDropHandler _dragDropHandler;

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void HandleOnClick()
		{
		}

		private bool Pressed()
		{
			return false;
		}

		private bool Dragging()
		{
			return false;
		}

		private bool Dropped()
		{
			return false;
		}
	}
}
