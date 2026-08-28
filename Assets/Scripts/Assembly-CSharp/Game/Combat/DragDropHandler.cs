using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class DragDropHandler : MonoBehaviour
	{
		[SerializeField]
		private LayerMask _dropableLayerMask;

		[SerializeField]
		private float _draggingZ;

		[SerializeField]
		private bool _fixDraggingPositionAtMouse;

		[SerializeField]
		private float _detectMotionRange;

		[SerializeField]
		private float _detectMotionDuration;

		[Header("Events")]
		[SerializeField]
		private UnityEvent _onStartDrag;

		[SerializeField]
		private UnityEvent _onDragging;

		[SerializeField]
		private UnityEvent<DropArea> _onDrop;

		[SerializeField]
		private UnityEvent _onTap;

		[Header("Runtime")]
		public bool Interactable;

		public Camera Cam;

		public DropArea DropArea;

		public Vector2 ExternalOffset;

		private bool _isDragging;

		private bool _hasDraggingMotion;

		private Vector3 _offset;

		private Vector3 _targetPosition;

		private float _dragStartTime;

		private Vector2 _startPosition;

		private float _hasMotionTime;

		private float _startPositionTweeningTime;

		private DropArea _currentHoveringDropArea;

		public bool ForceLock;

		public Vector3 InitialScale { get; private set; }

		public bool IsDragging => false;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private bool IsInteractable()
		{
			return false;
		}

		public void CustomOnMouseDown()
		{
		}

		public void CustomOnMouseDrag()
		{
		}

		private void HoveringHandling()
		{
		}

		public void CustomOnMouseUp()
		{
		}

		private void OnMouseUpAsButton()
		{
		}

		private void LateUpdate()
		{
		}

		private Vector3 GetMouseWorldPosition()
		{
			return default;
		}

		public void DropNInvoke()
		{
		}

		private void Drop()
		{
		}

		public void Cancel()
		{
		}

		public Collider2D[] TryGetDropAreas()
		{
			return null;
		}
	}
}
