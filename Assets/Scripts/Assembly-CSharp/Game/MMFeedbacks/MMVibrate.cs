using MoreMountains.Feedbacks;
using Solo.MOST_IN_ONE;
using UnityEngine;

namespace Game.MMFeedbacks
{
	[ExecuteAlways]
	[AddComponentMenu(null)]
	[FeedbackPath("Haptic/Vibrate")]
	public class MMVibrate : MMF_Feedback
	{
		[MMFInspectorGroup("Vibrate", true, 57, false, false)]
		public MOST_HapticFeedback.HapticTypes HapticType;

		public float Cooldown;

		public bool UseCustomPattern;

		public MOST_HapticFeedback.CustomHapticPattern CustomHaptic;

		protected override void CustomPlayFeedback(Vector3 position, float feedbacksIntensity = 1f)
		{
		}
	}
}
