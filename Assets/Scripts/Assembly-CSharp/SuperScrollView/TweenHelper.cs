using System;
using UnityEngine;

namespace SuperScrollView
{
	public class TweenHelper : MonoBehaviour
	{
		public Action<TweenHelper> OnTweenFinished;

		private bool mIsTweenFinishedHandlerAutoReset;

		public Vector3 StartPos { get; set; }

		public Vector3 EndPos { get; set; }

		public float TweenTotalTime { get; set; }

		public float TweenSpeed { get; set; }

		public RectTransform TweenTrans { get; set; }

		public float StartTweenTime { get; set; }

		public float TweenEndTime { get; set; }

		public bool IsTweenFinished { get; set; }

		public void SetTweenFinishedHandler(Action<TweenHelper> handler, bool autoReset)
		{
		}

		public bool DoUpdate()
		{
			return false;
		}

		public static TweenHelper TweenAnchorPosX(RectTransform trans, float endPosX, float speed)
		{
			return null;
		}

		public static TweenHelper TweenAnchorPosY(RectTransform trans, float endPosY, float speed)
		{
			return null;
		}
	}
}
