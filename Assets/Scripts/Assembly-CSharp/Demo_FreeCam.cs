using UnityEngine;

public class Demo_FreeCam : MonoBehaviour
{
	[Header("Focus Object")]
	[SerializeField]
	[Tooltip("Enable double-click to focus on objects?")]
	private bool doFocus;

	[SerializeField]
	private float focusLimit;

	[SerializeField]
	private float minFocusDistance;

	private float doubleClickTime;

	private float cooldown;

	[Header("Undo - Only undoes the Focus Object - The keys must be pressed in order.")]
	[SerializeField]
	private KeyCode firstUndoKey;

	[SerializeField]
	private KeyCode secondUndoKey;

	[Header("Movement")]
	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private float rotationSpeed;

	[SerializeField]
	private float zoomSpeed;

	private Quaternion prevRot;

	private Vector3 prevPos;

	[Header("Axes Names")]
	[SerializeField]
	[Tooltip("Otherwise known as the vertical axis")]
	private string mouseY;

	[SerializeField]
	[Tooltip("AKA horizontal axis")]
	private string mouseX;

	[SerializeField]
	[Tooltip("The axis you want to use for zoom.")]
	private string zoomAxis;

	[Header("Move Keys")]
	[SerializeField]
	private KeyCode forwardKey;

	[SerializeField]
	private KeyCode backKey;

	[SerializeField]
	private KeyCode leftKey;

	[SerializeField]
	private KeyCode rightKey;

	[Header("Flat Move")]
	[Tooltip("Instead of going where the camera is pointed, the camera moves only on the horizontal plane (Assuming you are working in 3D with default preferences).")]
	[SerializeField]
	private KeyCode flatMoveKey;

	[Header("Anchored Movement")]
	[Tooltip("By default in scene-view, this is done by right-clicking for rotation or middle mouse clicking for up and down")]
	[SerializeField]
	private KeyCode anchoredMoveKey;

	[SerializeField]
	private KeyCode anchoredRotateKey;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void FocusObject()
	{
	}

	private void SavePosAndRot()
	{
	}

	private void GoBackToLastPosition()
	{
	}

	private Vector3 GetOffset(Vector3 targetPos, Vector3 targetSize)
	{
		return default;
	}
}
