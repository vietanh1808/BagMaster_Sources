using Game.Combat;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.MMFeedbacks
{
	[ExecuteAlways]
	[AddComponentMenu(null)]
	[FeedbackPath("Custom/KillingBlow")]
	public class MMKillingBlow : MMF_Feedback
	{
		public enum PositionModes
		{
			FeedbackPosition = 0,
			WorldPosition = 1,
			Script = 2
		}

		[MMFInspectorGroup("KillingBlow", true, 57, false, false)]
		public GameObject KillingBlowPrefab;

		public PositionModes PositionMode;

		public Vector3 PositionOffset;

		public CharacterModel AnimatedSprite;

		public float RemainDuration;

		public Color FlashColor;

		public Color BackgroundColor;

		public bool DontKillWhenStop;

		private KillingBlow _currentFx;

		protected override void CustomPlayFeedback(Vector3 position, float feedbacksIntensity = 1f)
		{
		}

		protected override void CustomStopFeedback(Vector3 position, float feedbacksIntensity = 1f)
		{
		}

		protected virtual Vector3 GetPosition(Vector3 position)
		{
			return default;
		}

		public KillingBlow GetCurrent()
		{
			return null;
		}
	}
}
