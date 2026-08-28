using UnityEngine;

namespace Game
{
	public class ToastNotificationMessage : MonoBehaviour
	{
		[HideInInspector]
		public float messageTime;

		[HideInInspector]
		public RectTransform timerRectTransform;

		[HideInInspector]
		public bool leftToRight;

		private float initialWidth;

		private float timeElapsed;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void RenderTimer()
		{
		}

		public static void HideOnClick()
		{
		}
	}
}
