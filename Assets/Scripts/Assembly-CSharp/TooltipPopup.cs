using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TooltipPopup : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _title;

	[SerializeField]
	private GameObject _popupPanel;

	[SerializeField]
	private TextMeshProUGUI _description;

	[SerializeField]
	private Vector2 _offset;

	[SerializeField]
	private Image toolTipBg;

	[SerializeField]
	private Sprite[] bgSprites;

	[SerializeField]
	private MMF_Player _disappearFeedback;

	private Transform _anchor;

	private static TooltipPopup _currentInstance;

	private void Start()
	{
	}

	private void UpdateInfo(string title, string description)
	{
	}

	private void UpdatePosition(Transform anchor)
	{
	}

	private void UpdatePositionOffset(Vector2 offset)
	{
	}

	private void UpdateType(TooltipType tooltipType)
	{
	}

	public static void Show(string title, string description, Transform anchor, Vector2 offset, TooltipType tooltipType = TooltipType.Middle)
	{
	}

	public void Pop()
	{
	}
}
