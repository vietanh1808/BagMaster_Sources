using UnityEngine;

public class AutoPositionPopup : MonoBehaviour
{
	[SerializeField]
	protected GameObject _popupPanel;

	[SerializeField]
	protected Vector2 _offset;

	[Header("Arrow Settings")]
	[SerializeField]
	protected RectTransform _arrow;

	[SerializeField]
	protected float _arrowOffsetFromEdge;

	[SerializeField]
	protected float _screenPadding;

	[SerializeField]
	protected Vector2 _arrowAboveOffset;

	[SerializeField]
	protected Vector2 _arrowBelowOffset;

	protected Transform _anchor;

	protected RectTransform _popupRectTransform;

	protected Canvas _canvas;

	protected virtual void Start()
	{
	}

	protected virtual void UpdatePopupPosition()
	{
	}

	protected virtual void UpdateArrow(Vector2 anchorLocalPos, Vector2 popupPos, Vector2 popupSize, bool showBelow)
	{
	}

	public virtual void UpdatePosition(Transform anchor)
	{
	}
}
