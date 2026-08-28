using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToastNotification : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private List<ToastType> _toastTypes;

	public static bool isStoped;

	public static bool showTimerRender;

	public static TimerDirection timerDirection;

	public static MessageScreenPosition messageScreenPosition;

	public static Vector2 margin;

	public static bool darkTheme;

	public static float minimumMessageTime;

	public static bool hideOnClick;

	public static bool isHiding;

	public static bool isCanvasGroup;

	private static List<ToastType> toastTypes;

	private static Transform toastNotification;

	[Header("Default Message Patterns:")]
	[Tooltip("A _countdown image will be displayed on message as a timer")]
	[SerializeField]
	private bool _showTimerRender;

	[Tooltip("Disable it to use the default Light Theme on messages")]
	[SerializeField]
	private bool _darkTheme;

	[Tooltip("Minimun time that all messages will be displayed.")]
	[SerializeField]
	private float _minimumMessageTime;

	[Tooltip("Margin X and Y on the corners. Margin X doens't works with centralized messages.")]
	[SerializeField]
	private Vector2 _margin;

	[Tooltip("Stop the timer when mouse cursor is over the ToastNotification object")]
	[SerializeField]
	private bool _stopOnOver;

	[Tooltip("Hide/dismiss the message when it's clicked")]
	[SerializeField]
	private bool _hideOnClick;

	[Tooltip("Position of messages on screen")]
	[SerializeField]
	private MessageScreenPosition _messageScreenPosition;

	[Tooltip("Direction of timer _countdown. Auto will choose the best position relative to the Message Screen Position option.")]
	[SerializeField]
	private TimerDirection _timerDirection;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public static void Show(GameMessageType type, string messageText)
	{
	}

	public static void Show(GameMessageType type, string messageText, float timerInSeconds)
	{
	}

	public static void Show(GameMessageType type, string messageText, string iconName)
	{
	}

	public static void Show(GameMessageType type, string messageText, float timerInSeconds = -1f, string iconName = "")
	{
	}

	public static void HideToast()
	{
	}

	private static string Capitalize(string text)
	{
		return null;
	}
}
